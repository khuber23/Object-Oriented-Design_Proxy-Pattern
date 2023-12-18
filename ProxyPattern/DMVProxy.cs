using ObjectvilleDMV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
	public class DMVProxy : IDMV
	{
		private DMV realDMV;

		public DMVProxy()
		{

		}
		public void AddApplicant(Applicant a)
		{
			this.GetApplicants().Add(a);
		}

		public bool CheckAge(int age)
		{
			return age >= 16;
		}

		public void FillOutPaperwork()
		{
			Console.WriteLine("Filling out paperwork from home.");
		}

		public List<Applicant> GetApplicants()
		{
			if (realDMV == null)
			{
				this.realDMV = new DMV();
			}
			return realDMV.GetApplicants();
		}
	}
}
