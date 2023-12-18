using ObjectvilleDMV;
using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDMV dmvProxy = new DMVProxy();

            if (dmvProxy.CheckAge(16))
            {
                Console.WriteLine("Applicant can apply for a license.");
                dmvProxy.FillOutPaperwork();
            }
            else
            {
                Console.WriteLine("Applicant cannot apply for a license.");
            }

            Console.WriteLine();

            List<Applicant> applicants = dmvProxy.GetApplicants();

            applicants.ForEach(a => Console.WriteLine(a.ToString()));

            Console.Read();
        }
    }
}