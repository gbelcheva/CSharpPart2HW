function solve() {
    return function () {
        $.fn.listview = function (data) {
            var templateId = this.attr('data-template');
            var templateHTML = $('#' + templateId).html();
            var template = handlebars.compile(templateHTML);

            for (var index in data) {
                this.append(template(data[index]))
            }

            //chaining
            return this;
        };
    };
}

module.exports = solve;