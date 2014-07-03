#Lambdastyle

A minimal JSON-to-any transformation language.


* It's really **simple**. Basically the whole syntax is just a `->`.
* It's **streaming** so size of input/output is almost **unlimited**.
* Can transform JSON to **JSON, XML, HTML** or any other text.
* Can **preserve formatting** in JSON.
* By default just copies input so edits are **as easy as it gets**.

As Lambdastyle is currently only a **prototype**, please expect that some things will not work. Also Lambdastyle can change and is open to suggestions.

####.NET

	var lambdastyle = new LambdastylePrototype.Facade();
	var output = lambdastyle.ProcessString(input: "[1, 2, 3]", style: "[item] -> [|, true]");
	Console.WriteLine(output); // prints [1, 2, 3, true]

####Node.js

	var lambdastyle = require('lambdastyle-prototype'),
	    bag = { input: '[1, 2, 3]', style: '[item] -> [|, true]' };

	lambdastyle.processString(bag, function (err, output) {
	  if (err) throw err;
	  console.log(output); // prints [1, 2, 3, true]
	});

###[Live demo](http://lambdastyle.com)

##Development notes

To build it just open `LambdastylePrototype.sln` e.g. in Visual Studio or MonoDevelop. If you are using NCrunch, you need to re-open solution after initial build. This is .NET 4.5. When you clone, make sure to initialize git submodules.

### Directory structure

* `.` - starting point is `Processor.cs`.
* `CLI` - simple command-line interface to processor.
* `externals` - directory for git submodules. Customized version of Newtonsoft.Json (used for input parsing) is referenced from here.
* `Interpreter` - processor logic is here.
* `MakeNuGet` - directory for making NuGet package.
* `Node.js` - directory of Node module.
* `Parser` - this is style parser (including ANTLR3 project).
* `Properties` - just AssemblyInfo.
* `Test` - tests are here. They run fine in NCrunch.
* `Utils` - utility code used in processor.