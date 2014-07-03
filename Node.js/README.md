#Lambdastyle

A minimal JSON-to-any transformation language.


* It's really **simple**. Basically the whole syntax is just a `->`.
* It's **streaming** so size of input/output is almost **unlimited**.
* Can transform JSON to **JSON, XML, HTML** or any other text.
* Can **preserve formatting** in JSON.
* By default just copies input so edits are **as easy as it gets**.

As Lambdastyle is currently only a **prototype**, please expect that some things will not work. Also Lambdastyle can change and is open to suggestions.

	var lambdastyle = require('lambdastyle-prototype'),
	    bag = { input: '[1, 2, 3]', style: '[item] -> [|, true]' };

	lambdastyle.processString(bag, function (err, output) {
	  if (err) throw err;
	  console.log(output); // prints [1, 2, 3, true]
	});

###[Live demo](http://lambdastyle.com)

[GitHub](https://github.com/PawelStroinski/LambdastylePrototype) 

In order to use this module on Windows you will need [.NET Framework 4.5](http://www.microsoft.com/en-us/download/details.aspx?id=30653) or on Mac OS X / Linux you will need [Mono 3.4.0 (or newer) x64](http://www.go-mono.com/mono-downloads/download.html).