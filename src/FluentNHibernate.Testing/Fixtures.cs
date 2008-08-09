﻿using fit;
using fitlibrary;
using FluentNHibernate.Framework;
using FluentNHibernate.Framework.Fixtures;
using FluentNHibernate.Testing.DomainModel;
using System;

namespace DomainFixtureGeneration
{

    public partial class CaseFixture : DomainClassFixture<Case>
    {

        public CaseFixture(IRepository repository) : base(repository) { }
        public CaseFixture(Case subject, IRepository repository) : base(subject, repository) { }


        [Example("|Number is|[value]|")]
        public void NumberIs(Int64 propertyValue)
        {
            Subject.Number = propertyValue;
        }

        [Example("|Check|Number|is|[value]|")]
        public System.Int64 NumberIs()
        {
            return Subject.Number;
        }


        [Example("|Name is|[value]|")]
        public void NameIs(String propertyValue)
        {
            Subject.Name = propertyValue;
        }

        [Example("|Check|Name|is|[value]|")]
        public System.String NameIs()
        {
            return Subject.Name;
        }


        [Example("|Id is|[value]|")]
        public void IdIs(Int64 propertyValue)
        {
            Subject.Id = propertyValue;
        }

        [Example("|Check|Id|is|[value]|")]
        public System.Int64 IdIs()
        {
            return Subject.Id;
        }

    }

    public partial class CaseListFixture : DomainListFixture<Case>
    {

        public CaseListFixture() : base() { }
        public CaseListFixture(Action<Case[]> doneAction) : base(doneAction) { }


        public System.Int64 Number
        {
            set
            {
                subject.Number = value;
            }
        }

        public System.String Name
        {
            set
            {
                subject.Name = value;
            }
        }

        public System.Int64 Id
        {
            set
            {
                subject.Id = value;
            }
        }
    }

    public partial class ContactFixture : DomainClassFixture<Contact>
    {

        public ContactFixture(IRepository repository) : base(repository) { }
        public ContactFixture(Contact subject, IRepository repository) : base(subject, repository) { }


        [Example("|Id is|[value]|")]
        public void IdIs(Int64 propertyValue)
        {
            Subject.Id = propertyValue;
        }

        [Example("|Check|Id|is|[value]|")]
        public System.Int64 IdIs()
        {
            return Subject.Id;
        }

    }

    public partial class ContactListFixture : DomainListFixture<Contact>
    {

        public ContactListFixture() : base() { }
        public ContactListFixture(Action<Contact[]> doneAction) : base(doneAction) { }


        public System.Int64 Id
        {
            set
            {
                subject.Id = value;
            }
        }
    }
}

