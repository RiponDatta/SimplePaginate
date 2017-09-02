using System.Collections.Generic;
using System.Linq;

namespace SimplePaginate.FakeRepository
{
    public class FakeData
    {
        public IQueryable<CustomerVm> GetCustomer()
        {
            return new List<CustomerVm>
            {
                new CustomerVm { Id = 1, CompanyName = "Company A", LastName = "Bedecs", FirstName = "Anna", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "123 1st Street", City = "Seattle", State = "WA", PostalCode = "99999" },
                new CustomerVm { Id = 2, CompanyName = "Company B", LastName = "Gratacos Solsona", FirstName = "Antonio", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "123 2nd Street", City = "Boston", State = "MA", PostalCode = "99999" },
                new CustomerVm { Id = 3, CompanyName = "Company C", LastName = "Axen", FirstName = "Thomas", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "123 3rd Street", City = "Los Angelas", State = "CA", PostalCode = "99999" },
                new CustomerVm { Id = 4, CompanyName = "Company D", LastName = "Lee", FirstName = "Christina", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 4th Street", City = "New York", State = "NY", PostalCode = "99999" },
                new CustomerVm { Id = 5, CompanyName = "Company E", LastName = "O’Donnell", FirstName = "Martin", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "123 5th Street", City = "Minneapolis", State = "MN", PostalCode = "99999" },
                new CustomerVm { Id = 6, CompanyName = "Company F", LastName = "Pérez-Olaeta", FirstName = "Francisco", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 6th Street", City = "Milwaukee", State = "WI", PostalCode = "99999" },
                new CustomerVm { Id = 7, CompanyName = "Company G", LastName = "Xie", FirstName = "Ming-Yang", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "123 7th Street", City = "Boise", State = "ID", PostalCode = "99999" },
                new CustomerVm { Id = 8, CompanyName = "Company H", LastName = "Andersen", FirstName = "Elizabeth", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "123 8th Street", City = "Portland", State = "OR", PostalCode = "99999" },
                new CustomerVm { Id = 9, CompanyName = "Company I", LastName = "Mortensen", FirstName = "Sven", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 9th Street", City = "Salt Lake City", State = "UT", PostalCode = "99999" },
                new CustomerVm { Id = 10, CompanyName = "Company J", LastName = "Wacker", FirstName = "Roland", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 10th Street", City = "Chicago", State = "IL", PostalCode = "99999" },
                new CustomerVm { Id = 11, CompanyName = "Company K", LastName = "Krschne", FirstName = "Peter", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 11th Street", City = "Miami", State = "FL", PostalCode = "99999" },
                new CustomerVm { Id = 12, CompanyName = "Company L", LastName = "Edwards",  FirstName = "John", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "123 12th Street", City = "Las Vegas", State = "NV", PostalCode = "99999" },
                new CustomerVm { Id = 13, CompanyName = "Company M", LastName = "Ludick", FirstName = "Andre", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "456 13th Street", City = "Memphis", State = "TN", PostalCode = "99999" },
                new CustomerVm { Id = 14, CompanyName = "Company N", LastName = "Grilo", FirstName = "Carlos", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "456 14th Street", City = "Denver", State = "CO", PostalCode = "99999" },
                new CustomerVm { Id = 15, CompanyName = "Company O", LastName = "Kupkova", FirstName = "Helena", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "456 15th Street", City = "Honolulu", State = "HI", PostalCode = "99999" },
                new CustomerVm { Id = 16, CompanyName = "Company P", LastName = "Goldschmidt", FirstName = "Daniel", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "456 16th Street", City = "San Francisco", State = "CA", PostalCode = "99999" },
                new CustomerVm { Id = 17, CompanyName = "Company Q", LastName = "Bagel", FirstName = "Jean Philippe", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "456 17th Street", City = "Seattle", State = "WA", PostalCode = "99999" },
                new CustomerVm { Id = 18, CompanyName = "Company R", LastName = "Autier Miconi", FirstName = "Catherine", JobTitle = "Purchasing Representative", BusinessPhone = "(123)555-0100", Address = "456 18th Street", City = "Boston", State = "MA", PostalCode = "99999" },
                new CustomerVm { Id = 19, CompanyName = "Company S", LastName = "Eggerer", FirstName = "Alexander", JobTitle = "Accounting Assistant", BusinessPhone = "(123)555-0100", Address = "789 19th Street", City = "Los Angelas", State = "CA", PostalCode = "99999" },
                new CustomerVm { Id = 20, CompanyName = "Company T", LastName = "Li", FirstName = "George", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 20th Street", City = "New York", State = "NY", PostalCode = "99999" },
                new CustomerVm { Id = 21, CompanyName = "Company U", LastName = "Tham", FirstName = "Bernard", JobTitle = "Accounting Manager", BusinessPhone = "(123)555-0100", Address = "789 21th Street", City = "Minneapolis", State = "MN", PostalCode = "99999" },
                new CustomerVm { Id = 22, CompanyName = "Company V", LastName = "Ramos", FirstName = "Luciana", JobTitle = "Purchasing Assistant", BusinessPhone = "(123)555-0100", Address = "789 22th Street", City = "Milwaukee", State = "WI", PostalCode = "99999" },
                new CustomerVm { Id = 23, CompanyName = "Company W", LastName = "Entin", FirstName = "Michael", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 23th Street", City = "Portland", State = "OR", PostalCode = "99999" },
                new CustomerVm { Id = 24, CompanyName = "Company X", LastName = "Hasselberg", FirstName = "Jonas", JobTitle = "Owner", BusinessPhone = "(123)555-0100", Address = "789 24th Street", City = "Salt Lake City",                     State = "UT", PostalCode = "99999" },
                new CustomerVm { Id = 25, CompanyName = "Company Y", LastName = "Rodman", FirstName = "John", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 25th Street", City = "Chicago", State = "IL", PostalCode = "99999" },
                new CustomerVm { Id = 26, CompanyName = "Company Z", LastName = "Liu", FirstName = "Run", JobTitle = "Accounting Assistant", BusinessPhone = "(123)555-0100", Address = "789 26th Street", City = "Miami", State = "FL", PostalCode = "99999" },
                new CustomerVm { Id = 27, CompanyName = "Company AA", LastName = "Toh", FirstName = "Karen", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 27th Street", City = "Las Vegas", State = "NV", PostalCode = "99999" },
                new CustomerVm { Id = 28, CompanyName = "Company BB", LastName = "Raghav", FirstName = "Amritansh", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 28th Street", City = "Memphis", State = "TN", PostalCode = "99999" },
                new CustomerVm { Id = 29, CompanyName = "Company CC", LastName = "Lee", FirstName = "Soo Jung", JobTitle = "Purchasing Manager", BusinessPhone = "(123)555-0100", Address = "789 29th Street", City = "Denver", State = "CO", PostalCode = "99999" }
            }.AsQueryable();
        }
    }
}
