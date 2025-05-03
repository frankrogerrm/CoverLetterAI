
async function openNewTabAndGetContent(url) {
    alert(url);
    return new Promise((resolve, reject) => {
        var newTab = window.open(url, '_blank');
        
        //newTab.onload = function () {
        //    var content = newTab.document.body.innerText;
        //    newTab.close();
        //    resolve(content);
        //};
        //newTab.onerror = function () {
        //    reject("Failed to load the new tab.");
        //};
    });
}
