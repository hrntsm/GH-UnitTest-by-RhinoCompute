using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace GHCITest
{
    public class GHCITestInfo : GH_AssemblyInfo
    {
        public override string Name => "GHCITest Info";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("D4183AF1-684A-4196-8B62-A0311468622A");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}
