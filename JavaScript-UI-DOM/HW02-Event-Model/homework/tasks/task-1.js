/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){

  validator = {
    validateIfUndefined: function (item, itemName) {
      itemName = itemName || 'Value';

      if (item === undefined) {
        throw new Error(itemName + ' is undefined');
      }
    },
    validateIfDomElement: function(element, elementName){
      elementName = elementName || 'Value';

      validator.validateIfUndefined(element, elementName);
      if (!(element instanceof HTMLElement)) {
        throw new Error(elementName + ' must be a DOM element.' );
      }
    }
  };

  return function (selector) {
    var domElement,
        buttonElements,
        contentElements;

    domElement = document.getElementById(selector);
    domElement = domElement || selector;
    validator.validateIfDomElement(domElement, 'Found DOM element');

    buttonElements = document.getElementsByClassName('button');

    for (var index in buttonElements) {
        buttonElements[index].innerHTML = 'hide';
    }
    domElement.addEventListener('click', function(ev){
        var targetButton = ev.target,
            foundContent;
        if (targetButton.className.indexOf('button') >= 0) {
            foundContent = targetButton.nextElementSibling;
            while (foundContent && foundContent.className.indexOf('content') < 0) {
                foundContent = foundContent.nextElementSibling;
                if (foundContent.nextElementSibling.className.indexOf('button') >= 0) {
                    break;
                }
            }

            if (foundContent.style.display === 'none') {
                foundContent.style.display = '';
                targetButton.innerHTML = 'hide';
            } else {
                foundContent.style.display = 'none';
                targetButton.innerHTML = 'show';
            }
        }
    });
  };
};

module.exports = solve;