/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
 */

function solve() {
    var validator = {
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
        validateIfConvertibleToNumber: function(item, itemName){
            itemName = itemName || 'Value';

            if (!Number(item)) {
                throw new Error(itemName + ' cannot be converted into a number.');
            }
        },
        validateCount: function(count, countName){
            countName = countName || 'Value';

            validator.validateIfUndefined(count, countName);
            validator.validateIfNumber(count, countName);
            validator.validateIfConvertibleToNumber(count, countName);
            if (count < 1) {
                throw new Error(countName + ' must be greater than 1.');
            }
        }
    };

    return function (selector, count) {
        var $root,
            $ul,
            $li;

        validator.validateIfString(selector);
        $root = $(selector);
        validator.validateCount(count, 'Count');

        if ($root.length > 0) {


            $ul = $('<ul />')
                .addClass('items-list');

            $li = $('<li />')
                .addClass('list-item');

            var i;

            for (i = 0; i < count; i += 1) {
                $li.clone()
                    .text('List item #' + i)
                    .appendTo($ul);
            }

            $root.append($ul);
        }
    };
};

module.exports = solve;