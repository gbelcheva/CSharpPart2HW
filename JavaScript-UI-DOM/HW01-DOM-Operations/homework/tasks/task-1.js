/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed
*/

function solve() {
    validator = {
        validateIfUndefined: function (item, itemName) {
            itemName = itemName || 'Value';

            if (item === undefined) {
                throw new Error(itemName + ' is undefined');
            }
        },
        validateIfString: function (str, strName) {
            strName = strName || 'Value';

            if (typeof str !== 'string') {
                throw new Error(strName + ' is not a string');
            }
        },
        validateIfNumber: function (num, numName) {
            numName = numName || 'Value';

            if (typeof num !== 'number') {
                throw new Error(numName + ' is not a number');
            }
        },
        validateIfDomElement: function(element, elementName){
            elementName = elementName || 'Value';

            validator.validateIfUndefined(element, elementName);
            if (!(element instanceof HTMLElement)) {
                throw new Error(elementName + ' must be a DOM element.' );
            }
        },
        validateIfStringOrDomElement: function(elementOrString, elementOrStringName){
            elementOrStringName = elementOrStringName || 'Value';

            validator.validateIfUndefined(elementOrString, elementOrStringName);

            try{
                validator.validateIfString(elementOrString, elementOrStringName);
            }
            catch (ex){
                validator.validateIfDomElement(elementOrString, elementOrStringName);
            }
        },
        validateIfAtLeastTwoArguments: function(args, argsName){
            argsName = argsName || 'Value';

            validator.validateIfUndefined(args, argsName);
            if (args.length < 2) {
                throw new Error('You must pass at least two ' + argsName);
            }
        },
        validateIfArray: function(array, arrayName){
            arrayName = arrayName || 'Value';

            validator.validateIfUndefined(array, arrayName);
            if (!(array instanceof Array)) {
                throw new Error(arrayName + ' must be an array.');
            }
        },
        validateIfStringOrNumber: function(item, itemName){
            itemName = itemName || 'Value';

            validator.validateIfUndefined(item, itemName);

            try{
                validator.validateIfString(item);
            }
            catch (ex){
                validator.validateIfNumber(item);
            }
        }
    };



  return function (element, contents) {
      var domElement,
          fragment,
          div,
          currentDiv;

      validator.validateIfAtLeastTwoArguments(arguments, 'input parameters');
      validator.validateIfArray(contents, 'Contents');

      for (var index in contents) {
          validator.validateIfStringOrNumber(contents[index]);
      }

      domElement = document.getElementById(element);
      domElement = domElement || element;
      validator.validateIfDomElement(domElement, 'Found DOM element');

      fragment = document.createDocumentFragment();
      div = document.createElement('div');

      for (var index in contents) {
          currentDiv = div.cloneNode(true);
          currentDiv.innerHTML = contents[index];
          fragment.appendChild(currentDiv);
      }

      domElement.innerHTML = '';
      domElement.appendChild(fragment);
  };
};


var result = solve();
//
//document.body.innerHTML = '<div id="root"><h1>Tests</h1></div>';
//
//var count = 15,
//    contents = Array.apply(null, { length: count })
//        .map(function (_, index) {
//            return 'Content #' + index;
//        }),
//    selector = 'root';
//
//result(selector, contents);
//
//var $divs = $('#' + selector + ' *');
//console.log($divs);
//
//$divs.each(function (index, div) {
//    console.log(div.innerHTML);
//});

module.exports = solve;
