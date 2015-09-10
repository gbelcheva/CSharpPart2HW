//import sha1 from 'sha1'
import 'jquery'
import cookie from 'js/cookie.js'

function encode(username, password){
    return sha1(username + password);
}

var cookieName = 'sessionKey'

function setSessionKey(sessionKey) {
    cookie.set(cookieName, sessionKey, 10);
}

function getSessionKey() {
    return cookie.get(cookieName);
}

function removeSessionKey() {
    cookie.remove(cookieName);
}

export default {
    user: {
        register: function(username, password){
            var authcode = encode(username, password);
            $.ajax({
                url: '/user',
                type: 'post',
                data: {
                    username: username,
                    authCode: authcode
                }
            });
        },
        login: function(username, password) {
            var authcode = encode(username, password);
            return $.ajax({
                url: '/auth',
                type: 'post',
                data: {
                    username: username,
                    authCode: authcode
                }
            })
                .then(function(data) {
                    setSessionKey(data.sessionKey);
                    return data.username;
                })
        },
        logout: function(){
            var sessionKey = getSessionKey();
            return $.ajax({
                url: '/user',
                type: 'put',
                headers: {
                    'X-SessionKey': sessionKey
                }
            })
                .then(function(data) {
                    return removeSessionKey();
                })
        },
        current: function(){
            return getSessionKey();
        }
    },
    posts: {
        all: function(){

            //return [{
            //    "id": 1,
            //    "title": "Lorem ipsum",
            //    "body": "Lorem ipsum, lorem ipsum, and again lorem, lorem, loreeeeeeem",
            //    "postDate": "2014-07-28T05:05:33.853Z",
            //    "user": {
            //        "id": 1,
            //        "username": "Minkov"
            //    }
            //}, {
            //    "id": 2,
            //    "title": "Ipsum #2",
            //    "body": "Lorem ipsum, lorem ipsum, and again lorem, lorem, loreeeeeeem",
            //    "postDate": "2014-07-28T05:06:04.410Z",
            //    "user": {
            //        "id": 2,
            //        "username": "Yoda"
            //    }
            //}, {
            //    "id": 3,
            //    "title": "Again Ipsum",
            //    "body": "Lorem ipsum, lorem ipsum, and again lorem, lorem, loreeeeeeem",
            //    "postDate": "2014-07-28T05:06:15.090Z",
            //    "user": {
            //        "id": 1,
            //        "username": "Minkov"
            //    }
            //}];

            return $.ajax({
                url: '/post',
                type: 'get'
            })
        },
        add: function(title, body){
            return $.ajax({
                url: '/post',
                type: 'post',
                headers: {
                    'X-SessionKey': getSessionKey()
                },
                data: {
                    title: title,
                    body: body
                }
            })
        }
    }
}