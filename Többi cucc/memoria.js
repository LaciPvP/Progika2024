var kepekUrl=["sins1.jpg","sins2.jfif","sins3.jpg","sins4.jfif","sins5.jpg"];





function init()
{
//console.log("hahó");
kepKirakas();



}

function kepKirakas()
{
    let asztal = document.getElementById("asztal");

    for(let i = 0; i < kepekUrl.length; i++)
    {
        let uj = document.createElement("img");
        uj.src= "memoriakepek/" + kepekUrl[i];
        asztal.appendChild(uj);

    }
    
}