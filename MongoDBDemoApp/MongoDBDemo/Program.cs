using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "John",
            //    LastName = "Smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "101 Oak Street",
            //        City = "Scranton",
            //        State = "PA",
            //        ZipCode = "18512"
            //    }
            //};

            //db.InsertRecord("Users", person);

            var recs = db.LoadRecords<NameModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($"{ rec.FirstName } {rec.LastName}");
                Console.WriteLine();
            }


            //var recs = db.LoadRecords<PersonModel>("Users");
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id }: { rec.FirstName } {rec.LastName}");

            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("a5030a36-95ac-4ab3-8a7a-3174fff5094b"));

            //oneRec.DateOfBirth = new DateTime(1989, 8, 28, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            //db.DeleteRecords<PersonModel>("Users", oneRec.Id);


            Console.ReadLine();
        }
    }
}
