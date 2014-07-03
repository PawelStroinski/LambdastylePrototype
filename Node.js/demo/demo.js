var lambdastyle = require('lambdastyle-prototype'),
    bag = { input: '[1, 2, 3]', style: '[item] -> [|, true]' };

lambdastyle.processString(bag, function (err, output) {
  if (err) throw err;
  console.log(output); // prints [1, 2, 3, true]
});