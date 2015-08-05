function solve() {
    return function (selector) {
        var $dropdown,
            $select,
            options,
            $current,
            $optionsContainer;

        $dropdown = $('<div>')
            .addClass('dropdown-list');

        $select = $(selector)
            .css('display', 'none')
            .appendTo($dropdown);

        options = $select.find('option');

        $current = $('<div>')
            .addClass('current')
            .attr('data-value', '')
            .text('Select value');

        $optionsContainer = $('<div>')
            .addClass('options-container')
            .css({
                'position': 'absolute',
                'display': 'none'
            });

        $current.on('click', function () {
            $optionsContainer.css('display', '');
        });

        $optionsContainer.on('click', function (ev) {
            var $target = $(ev.target);

            $current.text($target.html());
            $select.val($target.attr('data-value'));

            $optionsContainer.css('display', 'none');
        });

        var i, len;
        for (i = 0, len = options.length; i < len; i += 1) {
            var divOption = $('<div>')
                .addClass('dropdown-item')
                .attr('data-value', $(options[i]).val())
                .attr('data-index', i)
                .text($(options[i]).text());

            $optionsContainer.append(divOption);
        }

        $dropdown.append($current)
            .append($optionsContainer);

        $('body').append($dropdown);
    };
}

module.exports = solve;
//
//var result = solve();
//
//var id = 'the-select',
//    select = document.createElement('select'),
//    count = 5;
//select.id = id;
//
//for (var i = 0; i < count; i += 1) {
//    var option = document.createElement('option');
//    option.innerHTML = 'Option #' + (i + 1);
//    option.value = (i + 1) + '';
//    select.appendChild(option);
//}
//
//document.body.innerHTML = select.outerHTML;
//
//result('#' + id);
//
//var clickEvent = document.createEvent('MouseEvents');
//clickEvent.initMouseEvent('click', true, true);
//
//var $dropdown = $('.dropdown-list');
//
//var $current = $dropdown.find('.current');
//$current.get(0).dispatchEvent(clickEvent);
//
//var clickedOption = $dropdown.find('.dropdown-item').get(Math.floor(count / 2));
//clickedOption.dispatchEvent(clickEvent);
//
//console.log($('#' + id).val() === clickedOption.getAttribute('data-value'));
//
//console.log($node.hasClass('dropdown-list') === false);