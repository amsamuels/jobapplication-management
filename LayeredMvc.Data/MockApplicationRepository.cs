using LayeredMvc.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LayeredMvc.Data
{
    public class MockApplicationRepository : IApplicationRepository
    {
        private const string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc laoreet dolor nec dui condimentum, id tempus nunc vehicula. Nullam eu eros at magna scelerisque aliquet. Suspendisse ante dui, ullamcorper ut sapien ut, gravida placerat diam. Nulla vehicula elementum posuere. Aenean at quam sem. Pellentesque in nisi et augue condimentum vulputate sit amet ut nisi. Praesent ac egestas sem. Nulla velit mauris, molestie sit amet scelerisque eu, molestie at quam. Fusce dictum nec mauris ut tincidunt. In eget elit varius, faucibus eros ut, fringilla neque. In sed aliquet neque, sit amet interdum arcu. Morbi quis semper ipsum, at rhoncus felis.\n\nDuis nisi felis, viverra ac blandit a, sagittis pellentesque quam.Mauris tristique nibh at diam viverra dapibus. Vestibulum fringilla nunc ut libero ullamcorper posuere.Aenean tellus libero, malesuada a volutpat ut, semper vel orci.Vivamus eget eros eros. Cras nec turpis quis metus volutpat finibus.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Curabitur ullamcorper ligula leo, sit amet elementum odio tempor at. Curabitur faucibus scelerisque egestas. Integer et ullamcorper lacus, nec tempor diam.";

        private List<Application> applications = new List<Application>()
        {
            new Application(2000, 1000, "Margaret Harris", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2001, 1000, "Dave Li", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2002, 1000, "Elaine Brice", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2003, 1001, "Ameena Pervez", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2004, 1003, "Kate Diaz", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2005, 1003, "David Collins", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2006, 1003, "Thomas Ali", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2007, 1003, "Luisa Dias", new DateTime(2019, 09, 01), LoremIpsum),
            new Application(2008, 1004, "Midori Green", new DateTime(2019, 09, 01), LoremIpsum)
        };

        public Application GetById(int applicationId)
        {
            return applications.First(x => x.Id == applicationId);
        }

        public List<Application> GetByJobId(int jobId)
        {
            return applications.Where(x => x.JobId == jobId).ToList();
        }
    }
}
