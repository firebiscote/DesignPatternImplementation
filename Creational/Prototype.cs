/* Le patron de conception prototype est utilisé lorsque la création d'une 
 * instance est complexe ou consommatrice en temps. Plutôt que créer plusieurs 
 * instances de la classe, on copie la première instance et on modifie la copie 
 * de façon appropriée.
 */

/* Prototype est un patron de conception qui crée de nouveaux objets à partir 
 * d’objets existants sans rendre le code dépendant de leur classe.
 * 
 * Complexité 1/3
 * Popularité 2/3
 * 
 * Le prototype est prêt à l’emploi dans C# avec une interface ICloneable.
 */

using System;
using System.Collections.Generic;

namespace DesignPatternImplementation.Creational.Prototype
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
