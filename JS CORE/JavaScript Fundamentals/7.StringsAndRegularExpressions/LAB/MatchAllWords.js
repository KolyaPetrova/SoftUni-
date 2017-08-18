function match (input) {
    if (Array.isArray(input)){
        input = input[0];
    }
    let result = input.match(/\w+/g);
    return result.join('|');
}
console.log(match(['A Regular Expression needs to have the global flag in order to match all occurrences in the text']));