using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplePaginate.FakeRepository;

namespace SimplePaginate.Tests
{
    [TestClass]
    public class SimplePaginateTests
    {
        private IQueryable<CustomerVm> _data;

        [TestInitialize]
        public void TestInitialize() => _data = new FakeData().GetCustomer();

        [TestMethod]
        public void TestPaginatePageCount()
        {
            // Arrange 
            var pageSize = 5;
            var pageNumber = 1;

            // Act
            var page = _data.SimplePaginate(pageNumber, pageSize);

            // Assert
            Assert.AreEqual(page.PageCount, Math.Ceiling((double)_data.Count() / pageSize));
        }

        [TestMethod]
        public void TestPaginateFilterByJobTitleOwner()
        {
            // Arrange 
            var pageSize = 5;
            var pageNumber = 1;
            var filters = new Filters<CustomerVm>();
            filters.Add(x => x.JobTitle.Equals("Owner"));

            // Act
            var page = _data.SimplePaginate(pageNumber, pageSize, filters);
            var totalOwner = _data.Count(x => x.JobTitle.Equals("Owner"));

            // Assert
            Assert.AreEqual(page.RecordCount, totalOwner);
        }

        [TestMethod]
        public void TestPaginateSortedByCompany()
        {
            // Arrange 
            var pageSize = 5;
            var pageNumber = 1;
            var sorts = new Sorts<CustomerVm>();
            sorts.Add(x =>x.CompanyName, true);

            // Act
            var page = _data.SimplePaginate(pageNumber, pageSize, sorts);
            var orderedData = _data.OrderByDescending(x => x.CompanyName);

            // Assert
            Assert.AreEqual(page.Results.FirstOrDefault()?.CompanyName, orderedData.FirstOrDefault()?.CompanyName);
        }

        [TestMethod]
        public void TestPaginateGroupedByJobTitle()
        {
            // Arrange 
            var pageSize = 5;
            var pageNumber = 1;
            var groups = new Groups<CustomerVm>();
            groups.Add(x => x.JobTitle);
             
            // Act
            var page = _data.SimplePaginate(pageNumber, pageSize, groups);
            var groupedByJobTitleAfterPaginate = page.Results.GroupBy(x => x.JobTitle).Select(x => x.ToList());
            var firstGroup = groupedByJobTitleAfterPaginate.FirstOrDefault();

            var flattenGroupedByjobTitle = _data.GroupBy(x => x.JobTitle).SelectMany(x => x.ToList()).ToList();

            // Assert
            var isTrue = true;
            for (int index = 0 ; index < firstGroup?.Count ; index++)
            {
                if (firstGroup[index].Id != flattenGroupedByjobTitle[index].Id)
                {
                    isTrue = false;
                }
            }
            
            Assert.IsTrue(isTrue);
        }
    }
}
