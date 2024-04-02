<h1>Description:</h1>
<p>This is a Full-stack web development course for .Net 5.0 that I put together based on the resources available online for a study group I led about one year ago.</p>
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
<p>https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022</p>
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
<p>https://www.youtube.com/watch?v=r3CExhZgZV8&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_</p>

<h4>Notes</h4>
<p></p>
<h5>Episode 5: Type casting</h5>
<p>Try to use Parse instead, as it allows for better debugging</p>
```cs
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
```
</p>

<h1 id="HTML&CSS">HTML & CSS</h1>

<h1 id="CORE">ASP.NET Core</h1>

<h1 id="BLAZOR">Blazor</h1>


