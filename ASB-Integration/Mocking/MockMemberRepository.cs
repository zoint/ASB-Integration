using System;
using System.Collections.Generic;
using ASB_Integration.Models;
using System.Linq;
using System.Web;

namespace ASB_Integration.Mocking
{
    public class MockMemberRepository
    {
        private List<string> FirstNames;
        private List<string> LastNames;
        private Member[] Members;

        public MockMemberRepository(int repositorySize)
        {
            Members = new Member[repositorySize];
            InitializeMocking();
        }

        private void InitializeMocking()
        {
            for (int i = 0; i < Members.Length; i++)
            {
                var member = new Member
                {
                    Id = i + 1,
                    FirstName = Faker.NameFaker.FirstName(),
                    LastName = Faker.NameFaker.LastName(),
                    HBID = Faker.NumberFaker.Number(),
                    Address = new Address()
                    {
                        Line1 = Faker.LocationFaker.StreetNumber() + Faker.LocationFaker.StreetName(),
                        Line2 = string.Empty,
                        City = Faker.LocationFaker.City(),
                        State = "NE",
                        Zip = Faker.LocationFaker.PostCode()
                    },
                    BenefitPlan = new BenefitPlan()
                    {
                        Id = Faker.NumberFaker.Number(),
                        Name = "Blue Pride",
                        NetworkId = Faker.NumberFaker.Number(),
                        ProductId = Faker.NumberFaker.Number()
                    }
                };

                Members[i] = member;
            }
        }

        internal Member Get(int id)
        {         
            try
            {
                return Members[id];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        internal IEnumerable<Member> GetAll()
        {
            return Members;
        }
    }
}