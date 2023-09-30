using CSharpStringExercises.Classes;

namespace CSharpStringExercises.Tests
{
	[TestClass]
	public class TestStringExercises
	{
		[TestMethod]
		[DataRow("Grab the doughnuts, now!", "rabGay hetay oughnutsday, ownay!")]
		[DataRow("You aren't making sense &,%%!", "ouYay ren'taay akingmay ensesay &,%%!")]
		[DataRow("The cat sat on the mat.", "heTay atcay atsay noay hetay atmay.")]
		[DataRow("\"How lovely to see you?\", said the lady.", "\"owHay ovelylay otay eesay ouyay?\", aidsay hetay adylay.")]
		public void TestPigLatin(string input, string output)
		{
			string result = StringExercises.PigLatin(input);
			Assert.AreEqual(output, result);
		}

		// The first test has been written for you
		// You will need to write the other tests yourself
		// Tests are needed for questions 2,5,6,7,8 and the extension 9.
	}
}