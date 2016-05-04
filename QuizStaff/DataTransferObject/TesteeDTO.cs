﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Setting UserSetting { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<TesteeTraining> Trainings { get; set; }

        public static implicit operator TesteeDTO(Testee testee)
        {
            return new TesteeDTO
            {
                Id = testee.ID,
                Login = testee.Login,
                FirstName = testee.FirstName,
                LastName = testee.LastName,
                Password = testee.Password,
                UserSetting = testee.UserSetting,
                Histories = testee.Histories,
                Trainings = testee.Trainings
            };
        }
    }
}