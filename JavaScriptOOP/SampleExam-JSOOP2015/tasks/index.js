function solve(){
    var solution = (function(){
        var player,
            playlist,
            playable,
            audio,
            video,
            validator,
            constants;

        constants = {
            MIN_TITLE_LENGTH: 3,
            MAX_TITLE_LENGTH: 25,
            MIN_IMDB_RATING: 1,
            MAX_IMDB_RATING: 5
        };

        validator = {
            validateIfUndefined: function(item, itemName){
                itemName = itemName || 'Value';

                if (item === undefined) {
                    throw new Error(itemName + ' is undefined');
                }
            },
            validateIfString: function(str, strName){
                strName = strName || 'Value';

                if (typeof str !== 'string') {
                    throw new Error(strName + ' is not a string');
                }
            },
            validateIfNumber: function(num, numName){
                numName = numName || 'Value';

                if (typeof num !== 'number') {
                    throw new Error(numName + ' is not a number');
                }
            },
            validateIfObject: function(obj, objName){
                objName = objName || 'Value';

                if (typeof obj !== 'object' && obj) {
                    throw new Error(objName + ' is not an object');
                }
            },
            validateString: function(str, strName){
                strName = strName || 'Value';

                validator.validateIfUndefined(str, strName);
                validator.validateIfString(str, strName);
                if (str.length < constants.MIN_TITLE_LENGTH || constants.MAX_TITLE_LENGTH < str.length) {
                    throw new Error(strName + ' must be between ' + constants.MIN_TITLE_LENGTH + ' and ' + constants.MAX_TITLE_LENGTH + ' symbols');
                }
            },
            validateAudioLength: function(length, lengthName){
                lengthName = lengthName || 'Value';

                validator.validateIfUndefined(length, lengthName);
                validator.validateIfNumber(length, lengthName);
                if (length <= 0) {
                    throw new Error(lengthName + ' must be greater than 0');
                }
            },
            validateIMDBRating: function(imdbRating, imdbRatingName){
                imdbRatingName = imdbRatingName || 'Value';

                validator.validateIfUndefined(imdbRating, imdbRatingName);
                validator.validateIfNumber(imdbRating, imdbRatingName);
                if (imdbRating < constants.MIN_IMDB_RATING || constants.MAX_IMDB_RATING < imdbRating) {
                    throw new Error(imdbRatingName + ' must be between ' + constants.MIN_IMDB_RATING + ' and ' + constants.MAX_IMDB_RATING);
                }
            },
            validatePaging: function(page, size, totalLength){
                validator.validateIfUndefined(page, 'Page');
                validator.validateIfUndefined(size, 'Size');
                validator.validateIfNumber(page, 'Page');
                validator.validateIfNumber(size, 'Size');
                if (page < 0) {
                    throw new Error('Page value cannot be a negative number');
                }
                if (size <= 0) {
                    throw new Error('Size value must be a positive number');
                }
                if (page * size > totalLength) {
                    throw new Error('Page * size value cannot exceed total number of items');
                }
            },
            validateIfPlayableExists: function(playable){
                if (playable === undefined) {
                    throw new Error('There is no such playable item');
                }
            },
            validateIfPlaylistInstance: function(playlist){
                if (!(playlist instanceof playlist.constructor)) {
                    throw new Error('Cannot add non-playlist items to player');
                }
            },
            validateIfPlaylistExists: function(playlist){
                if (playlist === undefined) {
                    throw new Error('There is no such playlist item');
                }
            }
        };

        function getID(itemOrId){
            if (typeof itemOrId === 'number') {
                return itemOrId;
            }

            return itemOrId.id;
        }

        function compareByTitleThenById(item1, item2) {
            if (item1.title < item2.title) {
                return -1;
            } else if (item1.title > item2.title) {
                return 1;
            }

            if (item1.id < item2.id) {
                return -1;
            } else if (item1.id > item2.id) {
                return 1;
            }

            return 0;
        }

        player = (function(){
            var player = Object.create([]),
                previousId = 0;

            Object.defineProperty(player, 'init', {
                value: function(name){
                    this.name = name;
                    this._id = ++previousId;

                    return this;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function(){
                    return this._name;
                },
                set: function(value){
                    validator.validateString(value, 'Player name');
                    this._name = value;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function(playlist){
                    validator.validateIfPlaylistInstance(playlist);
                    this.push(playlist);

                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function(id){
                    var foundPlaylist = this.filter(function(playlist){return playlist.id === id;});

                    if (foundPlaylist[0] === undefined) {
                        return null;
                    }

                    return foundPlaylist[0];
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function(playlistOrId){
                    var id = getID(playlistOrId),
                        foundPlaylists = this.filter(function(playlist){return playlist.id === id;});

                    validator.validateIfPlaylistExists(foundPlaylists[0]);
                    while (this.indexOf(foundPlaylists[0]) > -1) {
                        this.splice(this.indexOf(foundPlaylists[0]), 1);
                    }

                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function(page, size){
                    validator.validatePaging(page, size, this.length);

                    return this.slice()
                        .sort(compareByTitleThenById)
                        .filter(
                        function(playlist, index){
                            return (page * size) <= index &&
                                index < (page * size + size);
                        });
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function(playable, playlist){
                    var playlistId = getID(playlist),
                        playableId = getID(playable);

                    return this.slice()
                        .filter(function(currentPlaylist){ return playlistId === currentPlaylist.id;})[0]
                        .some(function(currentPlayable){ return playableId === currentPlayable.id});
                }
            });

            Object.defineProperty(player, 'search', {
                value: function(pattern){
                    var foundPlaylists = this.slice()
                        .filter(function(playlist){
                            return playlist.some(function(playable){
                                return RegExp(pattern.toLowerCase()).test(playable.title.toLowerCase());
                            })
                        });

                    if (foundPlaylists.length < 1) {
                        return [];
                    }

                    return foundPlaylists.map(function(playlist){
                        return {
                            id: playlist.id,
                            name: playlist.name
                        }})
                }
            });

            return player;
        }());

        playlist = (function(){
            var playlist = Object.create([]),
                previousID = 0;

            Object.defineProperty(playlist, 'init', {
               value: function(name){
                   this._id = ++previousID;
                   this.name = name;

                   return this;
               }
            });

            Object.defineProperty(playlist, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function(){
                    return this._name;
                },
                set: function(value){
                    validator.validateString(value, 'Playlist name');
                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function(playable){
                    this.push(playable);

                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function(id){
                    var foundPlayable = this.filter(function(playable){return playable.id === id;});

                    if (foundPlayable[0] === undefined) {
                        return null;
                    }

                    return foundPlayable[0];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function(playableOrId){
                    var id = getID(playableOrId),
                        foundPlayables = this.filter(function(playable){return playable.id === id;});

                    validator.validateIfPlayableExists(foundPlayables[0]);
                    while (this.indexOf(foundPlayables[0]) > -1) {
                        this.splice(this.indexOf(foundPlayables[0]), 1);
                    }

                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function(page, size){
                    validator.validatePaging(page, size, this.length);

                    return this.slice()
                        .sort(compareByTitleThenById)
                        .filter(
                        function (playable, index) {
                            return (page * size) <= index &&
                                index < (page * size + size);
                        });
                }
            });

            return playlist;
        }());

        playable = (function(){
            var playable = Object.create({}),
                previousID = 0;

            Object.defineProperty(playable, 'init', {
                value: function(title, author){
                    this._id = ++previousID;
                    this.title = title;
                    this.author = author;

                    return this;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function(){
                    return this._title;
                },
                set: function(value){
                    validator.validateString(value, 'Playable title');
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function(){
                    return this._author;
                },
                set: function(value){
                    validator.validateString(value, 'Playable author');
                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function(){
                    return this._id + '. ' + this.title + ' - ' + this.author;
                }

            });

            return playable;
        }());

        audio = (function(parent){
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function(title, author, length){
                    parent.init.call(this, title, author);
                    this.length = length;

                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get: function(){
                    return this._length;
                },
                set: function(value){
                    validator.validateAudioLength(value, 'Audio length');
                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function(){
                    return parent.play.call(this) + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        video = (function(parent){
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function(title, author, imdbRating){
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;

                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function(){
                    return this._imdbRating;
                },
                set: function(value){
                    validator.validateIMDBRating(value, 'IMDB rating');
                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function(){
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            });

            return video;
        }(playable));


        return{
            getPlayer: function (name) {
                return Object.create(player).init(name);            },
            getPlaylist: function (name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function (title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function (title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return solution;
}

module.exports = solve;