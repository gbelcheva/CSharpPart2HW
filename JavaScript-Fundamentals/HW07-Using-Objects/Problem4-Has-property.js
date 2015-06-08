//Problem 4. Has property
//
//Write a function that checks if a given object contains a given property.
//
//    var obj  = …;
//var hasProp = hasProperty(obj, 'length');
//

var hasProp,
    band = {
    name: 'Muse',
    'band members': ['Matthew Bellamy', 'Christopher Wolstenholme', 'Dominic Howard']
};

function hasProperty(obj, key) {
    if (Object.prototype.hasOwnProperty.call(obj, key)) {
        return true;
    }
    return false;
}

console.log(band);

hasProp = hasProperty(band, 'length');
console.log('Has property "length"? --> ' + hasProp);

hasProp = hasProperty(band, 'band members');
console.log('Has property "band members"? --> ' + hasProp);