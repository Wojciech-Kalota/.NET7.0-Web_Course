<h1>Description:</h1>
<p>This is a Full-stack web development course for .Net 5.0 that I put together based on the resources available online for a study group I led about one year ago.</p>
<p>The purpose of this course is to structure the learning process so that you learn things in order and have all the knowledge necessary to follow to the next step.</p>
<p>This course can be seperated into two overlapping sub-courses: one for Frontend and one for Backend.</p>
<p>The full course is divided into 4 sub-sections:</p>

<ul>
  <li><a href="#C">C#</li>
  <li><a href="#HTML&CSS">HTML & CSS</li>
  <li><a href="#CORE">ASP.NET Core</li>
  <li><a href="#BLAZOR">Blazor</li>
</ul>

<br/>

<p>Other technologies used/for you to explore:</p>
<ul>
  <li>SQLite</li>
  <li>Git</li>
  <li>EF Core</li>
  <li>Xunit</li>
  <li>Mediatr</li>
  <li>Visual Studio 2022</li>
</ul>

<br/>

<p>Disclaimer: I cannot guarantee that prepared materials will be available in the future nor that they will work on the newer releases of .Net, as I included the work of independent creators to which I have no affiliation. On this note, I would also like to credit them for their amazing work. They are doing the heavy lifting here, and I encourage you to check out their media for more useful content.</p>

<h2>Sub-courses:</h2>
<h3>Backend:</h3>
<ul>
  <li><a href="#C">C#</li>
  <li><a href="#CORE">ASP.NET Core</li>
</ul>
<h3>Frontend:</h3>
<ul>
  <li><a href="#C">C#</li>
  <li><a href="#HTML&CSS">HTML & CSS</li>
  <li><a href="#BLAZOR">Blazor</li>
</ul>
<br/>




<h1 id="C">C#</h1>
<p>Welcome to the first part of the course. Here you will learn C#, which is a programming language that we will be using for the rest of the course.</p>

<h3>Why C#</h3>
<p>It's a general purpose languege developed by Microsoft. It was pupular in the backend development for quite a while now, and with Blazor gaining traction in Frontend there is no better time to learn it. By learning C#, we will also be able to learn the Full-stack with just one programming language, and by doing so, we will be able to focus more on the web-dev paradigms rather than on the language syntax.</p>

<h3>IDE instalation</h3>
<p>First we need to download the IDE. For that we will be using Visual Studio 2022</p>
<p><a href="https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022">https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022</a></p>
<p>Go through the instalation. Make sure to select the following:</p>
<ul>
  <li>ASP.NET and web development</li>
  <li>.NET desktop development</li>
  <li>.NET WebAssembly build tools</li>
  <li>Git for Windows</li>
</ul>

<img src="/images/1.png">
<img src="/images/2.png">
<img src="/images/3.png">
<img src="/images/4.png">

<h3>Coding</h3>
<p>Now we are ready to start coding. For that please follow the tutorial Bro Code made while also looking at the notes I will list below.</p>
<p>Link to the tutorial</p>
<p><a href="https://www.youtube.com/watch?v=r3CExhZgZV8&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_">https://www.youtube.com/watch?v=r3CExhZgZV8&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_</a></p>

<h3>Notes</h3>
<p>Use <code>string</code> instead of <code>String</code></p>

<h4>Episode 5: Type casting</h4>
<p>Try to use Parse instead, as it allows for better debugging</p>
<pre><code>
string input = System.ReadLine();

// conversion string -> int with type safety
// public static bool TryParse(string s, out int result)
if (int.TryParse(input, out int number)
    Console.WriteLine("Valid number:" + number);
else
    Console.WriteLine("Invalid number");

// or:
// public static int Parse(string s)
int number2 = int.Parse(input);

// TryParse vs Parse:
// TryParse - returns true if the given text is a number and returns false otherwise. Number is stored in "out" variable.
// Parse - returns a number if conversion is possibly. Otherwise throwns an exception.
</code></pre>
<p>If the code above is unclear you can come back here after finishing all the videos</p>

<h4>Episode 23: C# methods</h4>
<p>For naming methods use <code>PascalCase</code> instead of <code>camelCase</code></p>

<h4>Bonus literature after watching all the videos. I would highly encourage you to read/watch the following to at least familiarize yourself with the tools at your disposal.</h4>
<p>Asynchronous programming (important!)</p>
<p><a href="https://www.youtube.com/watch?v=5a6WCBftjvw">https://www.youtube.com/watch?v=5a6WCBftjvw</a></p>
<p>Delegates</p>
<p><a href="https://learn.microsoft.com/en-us/dotnet/csharp/delegates-overview">https://learn.microsoft.com/en-us/dotnet/csharp/delegates-overview</a></p>
<p>Lambda expressions</p>
<p><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions">https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions</a></p>
<p>out</p>
<p><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#out-parameter-modifier">https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#out-parameter-modifier</a></p>
<p>IEnumerable<T></p>
<p><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-7.0">https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-7.0</a></p>
<p>LINQ<T></p>
<pre><code>
// LINQ - Language Integrated Query - operations on collections
int[] nums = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
// LINQ operates on the IEnumerable<T> interface (or IQueryable<T>)
// LINQ is "lazy" - subsequent operations do not process data until the received collection is "materialized", e.g. by calling .ToArray()
// LINQ **does not** modify the original data

// Select - operation (in this case x * 2) on each element of the collection
int[] numsDoubled = nums.Select(x => x * 2).ToArray();

// Reverse - reverses the collection
int[] numsReversed = nums.Reverse().ToArray(); // or in this case .OrderByDescending(key => key)

// Where - returns the elements of the collection that meet the given condition
int[] numsEven = nums.Where(x => x % 2 == 0).ToArray();

// Distinct - distincs collection items
int[] numsUnique = nums.Distinct().ToArray();

// Skip - skips n elements
int[] nums2 = nums.Skip(5).ToArray(); // { 8, 13, 21, 34 }

// Take - returns n elements
int[] nums3 = nums.Take(5).ToArray(); // { 1, 1, 2, 3, 5 }

// Skip + Take
int[] nums4 = nums.Skip(3).Take(4).ToArray(); // { 3, 5, 8, 13 }

// Concat - appends another collection
int[] nums5 = nums.Concat(nums.Reverse()).ToArray(); // { 1, 1, 2, 3, 5, 8, 13, 21, 34, 34, 21, 13, 8, 5, 3, 2, 1, 1 }

// All/Any - checks whether all/any element meets the condition
bool allEven = nums.All(x => x % 2 == 0); // false
bool anyEven = nums.Any(x => x % 2 == 0); // true

int one = nums.First(); // = 1
int last = nums.Last(); // = 34
int sum2 = nums.Skip(1).Sum(); // = 87

// more: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable#methods
// there is "query syntax", it ends up using the same methods
</code></pre>
<p>Naming conventions</p>
<pre><code>
// Types - always PascalCase
internal class Program
{
	// Constants - always PascalCase
	public const int DefaultNumber = 0;

	// Properties - always PascalCase
	private int Number { get; } = 4;
	
	// private fileds - camelCase
	private int number2 = 3;

	// Methods - always PascalCase
	static void Main(string[] args /*parameters and variables - camelCase*/)
	{
		var program = new Program();
		program.number = program.Number;
	}
}

// Interfaces - I + PascalCase
public interface IXyz
{
	void DoXyz();
}

// Two-letter abbreviations - ALL CAPS
struct IPAddress
{
	public uint Value { get; }
}

// 3+ letter abbreviations - 1. big letter
struct MacAddress
{
	public ulong Value { get; }
}
</code></pre>




<h1 id="HTML&CSS">HTML & CSS</h1>

<h1 id="CORE">ASP.NET Core</h1>

<h1 id="BLAZOR">Blazor</h1>


