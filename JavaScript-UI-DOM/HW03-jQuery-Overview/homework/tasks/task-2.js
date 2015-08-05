/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
    var validator = {
        validateIfUndefined: function (item, itemName) {
            itemName = itemName || 'Value';

            if (item === undefined) {
                throw new Error(itemName + ' is undefined');
            }
        },
        validateIfFalsy: function (item, itemName) {
            itemName = itemName || 'Value';

            if (!item) {
                throw new Error(itemName + ' is falsy.');
            }
        },
        validateIfAtLeastOneArguments: function(args, argsName){
            argsName = argsName || 'Value';

            validator.validateIfUndefined(args, argsName);
            if (args.length < 1) {
                throw new Error('You must pass at least one ' + argsName);
            }
        },
        validateIfEmptyCollection: function(collection, collectionName){
            collectionName = collectionName || 'Value';

            validator.validateIfUndefined(collection, collectionName);
            if (collection.length < 1) {
                throw new Error('The collection ' + collectionName + ' cannot be empty.');
            }
        }
    };

    return function (selector) {
        var $buttons,
            $contents;
        var $root = $(selector);

        validator.validateIfAtLeastOneArguments(arguments);
        validator.validateIfFalsy(selector);
        validator.validateIfEmptyCollection($root);

        $buttons = $root.find('.button').text('hide');
        $contents = $root.find('.content');

        $root.on('click', '.button', function () {
            var $this = $(this);
            var $foundContent = $this.next();
            var contentIsFound = false;

            while ($foundContent) {
                if ($foundContent.hasClass('button')) {
                    break;
                } else if ($foundContent.hasClass('content')) {
                    contentIsFound = true;
                    break;
                }

                $foundContent = $foundContent.next();
            }

            if (contentIsFound) {
                if ($foundContent.css('display') === 'none') {
                    $foundContent.css('display', '');
                    $this.text('hide');
                } else {
                    $foundContent.css('display', 'none');
                    $this.text('show');
                }
            }
        });
    };
};

module.exports = solve;