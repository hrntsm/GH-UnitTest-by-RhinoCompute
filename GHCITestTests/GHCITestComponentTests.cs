using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Compute;
using Newtonsoft.Json;

namespace GHCITest.Tests
{
    [TestClass]
    public class GHCITestComponentTests
    {
        [TestMethod]
        public void GHCITestComponentTest()
        {
            ComputeServer.WebAddress = "http://localhost:8081/";

            var definitionName = "testgh.gh";
            var definitionPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            definitionPath = Path.GetDirectoryName(definitionPath);
            definitionPath = Path.Combine(definitionPath, definitionName);

            var trees = new List<GrasshopperDataTree>();

            var value1 = new GrasshopperObject(10);
            var param1 = new GrasshopperDataTree("A");
            param1.Add("0", new List<GrasshopperObject> { value1 });
            trees.Add(param1);

            var value2 = new GrasshopperObject(35);
            var param2 = new GrasshopperDataTree("B");
            param2.Add("0", new List<GrasshopperObject> { value2 });
            trees.Add(param2);


            var result = Rhino.Compute.GrasshopperCompute.EvaluateDefinition(definitionPath, trees);
            var data = result[0].InnerTree.First().Value[0].Data;
            Assert.AreEqual(45, double.Parse(data));
        }
    }
}
