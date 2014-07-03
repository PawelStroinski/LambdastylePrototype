var edge = require('edge'),
    path = require('path');

module.exports = {
  processString: function (bag, callback) {
    var dllPath = path.join(__dirname, 'bin', 'LambdastylePrototype.dll');
    var wrapper = edge.func({ source: function () {/*
      async (dynamic bag) => {
          var input = (string)bag.input;
          var style = (string)bag.style;
          var lambdastyle = new LambdastylePrototype.Facade();
          var output = lambdastyle.ProcessString(input: input, style: style);
          return output;
      }
    */}, references: [dllPath] });
    return wrapper(bag, callback);
  }
};