async function DoWork(){
    return new Promise((resolve,reject) => {
        // call resolve() if Promise resolves
        // call reject() if Promise fails
        // you can call resolve(data) -> where data is a single value (object, etc..)
        // DO NOT call resolve(data,data2) -> data2 will be the reject value, so promise will resolve and reject
    });
}

// ======================================
// Calling Examples
// ======================================

// example 1 (nested Promises)
await DoWork().then((res) => {
    // use the gotten value
}).catch(((rej) => {
    // error handling
}));

// example 2 (value assignment over resolve) || NOT RECOMMENDED DUE TO EXTRA IF STATEMENT
// example(var) will be assigned the resolved data if it resolves
let example = await DoWork().catch((err) => {
    // error handling
});
if (example == null){
    // failed
}



