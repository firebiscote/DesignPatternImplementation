using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternImplementation
{
    public enum RecordType
    {
        Car,
        Person
    }

    public abstract class Record
    {
        public abstract Record Clone();
    }

    public class PersonRecord : Record
    {
        string name;
        int age;

        public override Record Clone()
        {
            return (Record)this.MemberwiseClone();
        }
    }

    public class CarRecord : Record
    {
        string carName;
        Guid id;

        public override Record Clone()
        {
            CarRecord clone = (CarRecord)this.MemberwiseClone();
            clone.id = Guid.NewGuid();
            return clone;
        }
    }

    public class RecordFactory
    {
        private static Dictionary<RecordType, Record> prototypes = new Dictionary<RecordType, Record>();

        public RecordFactory()
        {
            prototypes.Add(RecordType.Car, new CarRecord());
            prototypes.Add(RecordType.Person, new PersonRecord());
        }
        public Record CreateRecord(RecordType type)
        {
            return prototypes[type].Clone();
        }
    }
}
