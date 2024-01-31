var kepekUrl=["sins1.jpg","sins2.jfif","sins3.webp","sins4.jpg","sins5.webp","sins6.jpg"]
var parDb = 6;
function init()
{
    
    kepBe();
}


function kepBe(){
    let asztal = document.getElementById("asztal");
    let kartyak = []
    var kattintas = 0;
    for(let k = 0; k < 2; k++)
    {
        for(let i = 0;i<parDb;i++)
        {
        
            /*
            let uj = document.createElement("img");
            uj.src = "kepek/" + kepekUrl[i];
            asztal.appendChild(uj);
            */

            let uj = document.createElement("div");
            uj.className="kartya";
            uj.onclick=function()
            {
                if(kattintas < 2)
                {
                    uj.style.backgroundImage="url(kepek/"+kepekUrl[i]+")"
                }

                kattintas++

                if(kattintas === 2 )
                {
                     setTimeout(visszaFordit,2000);
                }
                
            
                
            }
            kartyak.push(uj);
        }
    }
 
kartyak = kever(kartyak);


function visszaFordit()
{
    console.dir("ssssssss")
}

for(let i = 0; i < kartyak.length; i++)
{
asztal.appendChild(kartyak[i]);
}
}



function kever(points)
{
    console.log(points.length)
    console.dir(points);
    for(let i = points.length -1; i > 0; i--)
    {
        console.log(i);
        let j = Math.floor(Math.random() * (i+1));
        let k = points[i];
        points[i] = points[j];
        points[j] = k;


    }
    return points;


}