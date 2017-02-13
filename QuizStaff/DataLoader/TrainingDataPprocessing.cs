using DAL;
using DAL.Repositories;
using DomainModel;
using LoaderModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public class TrainingDataPprocessing
    {
        public static void SynchronizeTrainings(QuizDBContext context, List<string> trainingTitles, List<LoadedQuestion> questions)
        {
            var loadedQuestions = questions;
            EFRepository<Question> questionRepo = new EFRepository<Question>(context);

            trainingTitles = trainingTitles.Distinct().ToList();
            List<Training> trainings = new List<Training>();
            EFTrainingRepository repo = new EFTrainingRepository(context);
            var allTrainings = new List<Training>(repo.ReadAll());

            trainings.AddRange((from title in trainingTitles
                                select new { title }).AsEnumerable().Select(x =>
                                {
                                    return (allTrainings.Select(_ => _.TrainingTitle).Contains(x.title))
                                        ? UpdatedExistingTraining(allTrainings.Where(_ => _.TrainingTitle == x.title).First(),
                                        loadedQuestions.Where(_ => _.Training == x.title).ToList())
                                        : CreateNewTraining(x.title,
                                        loadedQuestions.Where(_ => _.Training == x.title).ToList());
                                }));

            //TODO: update delete
            trainings.AddRange(allTrainings.Except(trainings).Select(x => DeleteExistingTraining(x)));

            WriteTraininToDB(trainings, repo);
        }

        public static void SynchronizeAdditionalTrainings(QuizDBContext context, List<string> trainingTitles, List<LoadedQuestion> questions)
        {
            var loadedQuestions = questions;
            EFRepository<Question> questionRepo = new EFRepository<Question>(context);

            trainingTitles = trainingTitles.Distinct().ToList();
            List<Training> trainings = new List<Training>();
            EFTrainingRepository repo = new EFTrainingRepository(context);
            var allTrainings = new List<Training>(repo.ReadAll());

            trainings.AddRange((from title in trainingTitles
                                select new { title }).AsEnumerable().Select(x =>
                                {
                                    return (allTrainings.Select(_ => _.TrainingTitle).Contains(x.title))
                                        ? UpdatedExistingTraining(allTrainings.Where(_ => _.TrainingTitle == x.title).First(),
                                        loadedQuestions.Where(_ => _.Training == x.title).ToList())
                                        : CreateNewAdditionalTraining(x.title,
                                        loadedQuestions.Where(_ => _.Training == x.title).ToList());
                                }));

            //TODO: update delete
            trainings.AddRange(allTrainings.Except(trainings).Where(_=>_.IsAdditional).Select(x => DeleteExistingTraining(x)));

            WriteTraininToDB(trainings, repo);
        }

        #region Training

        private static Training CreateNewAdditionalTraining(string title, List<LoadedQuestion> questions)
        {
            Training newTraining = new Training();

            newTraining.TrainingTitle = title;
            newTraining.IsActive = true;
            newTraining.Questions = AddQuestions(questions);
            newTraining.IsAdditional = true;
            //TODO: check
            //existingTraining.TesteeTrainings = new BindingList<TesteeTrainings>();

            return newTraining;
        }

        private static Training CreateNewTraining(string title, List<LoadedQuestion> questions)
        {
            Training newTraining = new Training();

            newTraining.TrainingTitle = title;
            newTraining.IsActive = true;
            newTraining.Questions = AddQuestions(questions);
            newTraining.IsAdditional = false;

            //TODO: check
            //existingTraining.TesteeTrainings = new BindingList<TesteeTrainings>();

            return newTraining;
        }

        private static Training UpdatedExistingTraining(Training existingTraining, List<LoadedQuestion> questions)
        {
            existingTraining.IsActive = true;
            UpdateQuestions(existingTraining, questions);

            //TODO: check
            //existingTraining.TesteeTrainings = newTraining.TesteeTrainings;

            return existingTraining;
        }

        private static Training DeleteExistingTraining(Training existingTraining)
        {
            if (!existingTraining.IsAdditional)
            {
                existingTraining.IsActive = false;
                DeleteQuestions(existingTraining.Questions);
            }

            return existingTraining;
        }

        #endregion

        #region Question

        private static BindingList<Question> AddQuestions(List<LoadedQuestion> questions)
        {
            BindingList<Question> newQuestions = new BindingList<Question>();

            foreach (var question in questions)
            {
                newQuestions.Add(CreateQuestion(question.Question, question.Answers));
            }

            return newQuestions;
        }

        private static Question CreateQuestion(string questionText, List<LoadedAnswer> answers)
        {
            Question createedQuestion = new Question();
            createedQuestion.QuestionText = questionText;
            createedQuestion.Answers = new BindingList<Answer>();

            foreach (var a in answers)
            {
                createedQuestion.Answers.Add(AddAnswer(a));
            }

            createedQuestion.IsActive = true;

            return createedQuestion;
        }

        private static void UpdateQuestions(Training training, List<LoadedQuestion> questions)
        {
            var existingQuestion = training.Questions;
            var questionFromFile = questions.Select(_ => _.Question).ToList();

            foreach (var q in existingQuestion)
            {
                if (questionFromFile.Contains(q.QuestionText))
                {
                    //update question
                    q.IsActive = true;
                    UpdateAnswers(q, questions.First(_ => _.Question == q.QuestionText).Answers);
                    questionFromFile.Remove(q.QuestionText);
                }
                else
                {
                    //Remove question
                    q.IsActive = false;
                    q.Answers.ToList().ForEach(_ => _.IsActive = false);
                    questionFromFile.Remove(q.QuestionText);
                }
            }

            var newQuestion = questions.Where(_ => questionFromFile.Contains(_.Question)).ToList();

            //Add new question
            newQuestion.ForEach(_ => training.Questions.Add(CreateQuestion(_.Question, _.Answers)));
        }

        private static void DeleteQuestions(BindingList<Question> questions)
        {
            questions.ToList().ForEach(_ => _.IsActive = false);
            questions.ToList().ForEach(_ => DeleteAnswers(_.Answers));
        }

        #endregion

        #region Answers

        private static Answer AddAnswer(LoadedAnswer loadedAnswer)
        {
            Answer answer = new Answer();
            answer.AnswerText = loadedAnswer.Answer;
            answer.IsCorrect = (loadedAnswer.IsCorrect == "correct");
            answer.IsActive = true;
            return answer;
        }

        private static void UpdateAnswers(Question question, List<LoadedAnswer> loadedAnswers)
        {
            var existingAnswers = question.Answers;

            var answersFromFile = loadedAnswers.Select(_ => _.Answer).ToList();

            foreach (var a in existingAnswers)
            {
                a.IsActive = answersFromFile.Contains(a.AnswerText);
                answersFromFile.Remove(a.AnswerText);
            }

            var newAnswers = loadedAnswers.Where(_ => answersFromFile.Contains(_.Answer)).ToList();

            //Add new answer
            newAnswers.ForEach(_ => question.Answers.Add(AddAnswer(_)));
        }

        private static void DeleteAnswers(BindingList<Answer> answers)
        {
            answers.ToList().ForEach(_ => _.IsActive = false);
        }

        #endregion

        private static void WriteTraininToDB(List<Training> allTrainings, EFTrainingRepository repo)
        {
            foreach (var training in allTrainings)
            {
                if (training.Id == Guid.Empty)
                {
                    repo.Create(training);
                }
                else
                {
                    //repo.Update(training);
                }
            }
        }
    }
}
