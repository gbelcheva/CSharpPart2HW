import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import notifier from 'js/notifier.js'

export default {
    all: function(sammy){
        var size = +sammy.params['size'] || 2,
            page = +sammy.params['page'] || 0;

        Promise.all([data.posts.all(), templates.load('posts')])
        .then(function([data, templateHtml]){
                var pages = (data.length / size);
                data = data.slice(page*size, (page + 1)*size);

                $('#main').html(templateHtml({
                    posts: data,
                    pages: pages
                }))
            });


        $('#main').on('click', '#btn-post', function(ev){
            var title = $('#post-title')[0].value,
                body = $('#post-body')[0].value;

            data.posts.add(title, body)
                .then(function(data){
                    notifier.success('Message posted.');
                    window.location = window.location.origin;
                }, function(err){
                    window.location = window.location.origin + '#/login';
                });
        });

        $('#main').on('click', '#btn-filter', function(ev){
            var size = $('#dd-page-size option:selected').text(),
                page = 0;

            sammy.redirect('#/posts/' + size + '/' + page);


        })

    },
    add: function(){}
}