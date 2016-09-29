using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DomainModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataFromLMS
{
    public static class Loader
    {
        static WorkbookPart workbookPart;
        public static List<TesteeTrainingLink> TesteesList = new List<TesteeTrainingLink>();
        public static List<TesteeData> TesteesTrainingsList = new List<TesteeData>();
        public static List<LoadedQuestion> LoadedQuestions = new List<LoadedQuestion>();

        private static List<Training> TrainingsList = new List<Training>();

        public static void LoadDataFromFile(string path)
        {
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(path, false);
            workbookPart = spreadsheetDocument.WorkbookPart;
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
            Worksheet sheet = worksheetPart.Worksheet;
            var cells = sheet.Descendants<Cell>();
            var rows = sheet.Descendants<Row>();

            foreach (Row row in rows.Skip(2))
            {
                var rowCells = row.Elements<Cell>();

                TesteeTrainingLink currentDataElement = new TesteeTrainingLink();
                currentDataElement.login = ConvertToString(rowCells.ElementAt(0));
                currentDataElement.training = ConvertToString(rowCells.ElementAt(6));
                currentDataElement.assignmentDate = DateTime.FromOADate(double.Parse(ConvertToString(rowCells.ElementAt(7))));
                currentDataElement.activityStatus = (ActivityStatus)Enum.Parse(typeof(ActivityStatus), ConvertToString(rowCells.ElementAt(8)));
                currentDataElement.attemptStartDate = DateTime.FromOADate(double.Parse(ConvertToString(rowCells.ElementAt(9))));
                currentDataElement.attemptEndDate = DateTime.FromOADate(double.Parse(ConvertToString(rowCells.ElementAt(10))));
                currentDataElement.dueDate = DateTime.FromOADate(double.Parse(ConvertToString(rowCells.ElementAt(11))));
                if (!currentDataElement.login.Contains("Questionnaire"))
                    TesteesList.Add(currentDataElement);

                TesteeData currentTestee = new TesteeData();
                currentTestee.login = ConvertToString(rowCells.ElementAt(0));
                currentTestee.firstName = ConvertToString(rowCells.ElementAt(1));
                currentTestee.lastName = ConvertToString(rowCells.ElementAt(2));
                currentTestee.managerLogin = ConvertToString(rowCells.ElementAt(3));
                currentTestee.department = ConvertToString(rowCells.ElementAt(4));
                currentTestee.possition = ConvertToString(rowCells.ElementAt(5));
                TesteesTrainingsList.Add(currentTestee);
            }
        }

        public static void LoadQuestionFromFile(string path)
        {
            //заполнить список тренингов TrainingsList
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName);
            }
        }

        public static void ProcessFile(string path)
        {
            var trainingTitle = Path.GetFileNameWithoutExtension(path);
            var currentTraining = TrainingsList.Where(_ => _.TrainingTitle == trainingTitle);

            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(path, false);
            workbookPart = spreadsheetDocument.WorkbookPart;
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
            Worksheet sheet = worksheetPart.Worksheet;
            var cells = sheet.Descendants<Cell>();
            var rows = sheet.Descendants<Row>();

            LoadedQuestion currentDataElement = new LoadedQuestion();
            foreach (Row row in rows.Skip(2))
            {
                var rowCells = row.Elements<Cell>();
                var question =  ConvertToString(rowCells.ElementAt(0));
                var test = ConvertToString(rowCells.ElementAt(1));
                if (test == null)
                {
                    LoadedQuestions.Add(currentDataElement);
                    currentDataElement = new LoadedQuestion();
                    currentDataElement.Answers = new List<LoadedAnswer>();
                    currentDataElement.Question = question;
                }
                else
                {
                    var answer = new LoadedAnswer();
                    answer.Answer = ConvertToString(rowCells.ElementAt(0));
                    answer.IsCorrect = ConvertToString(rowCells.ElementAt(1));
                    currentDataElement.Answers.Add(answer);
                }
            }
        }

        public static SharedStringItem GetSharedStringItemById(WorkbookPart workbookPart, int id)
        {
            return workbookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(id);
        }

        private static string ConvertToString(Cell cell)
        {
            string cellValue = string.Empty;
            if (cell.DataType != null)
            {
                if (cell.DataType == CellValues.SharedString)
                {
                    int id = -1;
                    if (Int32.TryParse(cell.InnerText, out id))
                    {
                        SharedStringItem item = GetSharedStringItemById(workbookPart, id);
                        if (item.Text != null)
                        {
                            cellValue = item.Text.Text;
                        }
                        else if (item.InnerText != null)
                        {
                            cellValue = item.InnerText;
                        }
                        else if (item.InnerXml != null)
                        {
                            cellValue = item.InnerXml;
                        }
                    }
                }
            }
            else
            {
                cellValue = cell.CellValue.Text;
            }

            return cellValue;
        }
    }
}
