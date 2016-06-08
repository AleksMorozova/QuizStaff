using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeDTO
    {
        private BindingList<TrainingDTO> trainings;
        public TesteeDTO() 
        {
            trainings = new BindingList<TrainingDTO>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Setting UserSetting { get; set; }
        public virtual ICollection<HistoryDTO> Histories { get; set; }
        public virtual BindingList<TrainingDTO> Trainings { get { return trainings; } set { trainings = value; } }

        public static implicit operator TesteeDTO(Testee testee)
        {
            TesteeDTO newTeste = new TesteeDTO();
            Conversion.CopyProperty(testee, newTeste);

            if (testee.Trainings.Count() > 0)
            {
                foreach (var q in testee.Trainings)
                {
                    newTeste.Trainings.Add((TrainingDTO)q.Training);
                }
            }

            return newTeste;
        }
    }
}
