﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Testee : Entity
    {
        public string FirstName  { get; set; }
        public string LastName {get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsSelected { get; set; }

        public virtual Setting UserSetting { get;set; }
        public virtual BindingList<History> Histories { get; set; }
        public virtual BindingList<TesteeTraining> Trainings { get; set; }
        public virtual BindingList<TesteeRoles> Roles { get; set; }

        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public string Attribute6 { get; set; }
        public string Attribute7 { get; set; }
        public string Attribute8 { get; set; }
        public string Attribute9 { get; set; }
        public string Attribute10 { get; set; }
    }
}
