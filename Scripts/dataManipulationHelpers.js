//JS Helper functions - TODO: Move this into it's own file
function isEmpty(x) {
    return (
        (typeof x == 'undefined')
        ||
        (x == null)
        ||
        (x == "null")
        ||
        (x == false)  //same as: !x
        ||
        (x.length == 0)
        ||
        (x == "")
        ||
        (!/[^\s]/.test(x))
        ||
        (/^\s*$/.test(x))
    );
}