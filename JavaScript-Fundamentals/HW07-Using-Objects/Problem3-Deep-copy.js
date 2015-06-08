//Problem 3. Deep copy
//
//Write a function that makes a deep copy of an object.
//    The function should work for both primitive and reference types.

var bandShallow,
    bandDeep;
band = {
    name: 'Muse',
    'band members': ['Matthew Bellamy', 'Christopher Wolstenholme', 'Dominic Howard']
};

function clone(obj) {
    var deepClone = {}
    if (obj === null || typeof(obj) !== 'object') {
        return obj;
    }
    for (var key in obj) {
        deepClone[key] = clone(obj[key]);
    }
    return deepClone;
}

bandShallow = band;
bandDeep = clone(band);

bandDeep['band members'][0] = 'deep copy';
console.log(bandDeep['band members'][0] + ' | ' + band['band members'][0]);

bandShallow['band members'][0] = 'shallow copy';
console.log(bandShallow['band members'][0] + ' | ' + band['band members'][0]);

