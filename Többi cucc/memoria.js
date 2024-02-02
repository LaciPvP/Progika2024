var kepekUrl=["sins1.jpg","sins2.jfif","sins3.jpg","sins4.jfif","sins5.jpg"];
var parDb=4;

function init()
{
    kepKirakas();
}
var kattintas = 0
function kepKirakas()
{
    let asztal=document.getElementById("asztal");
    let kartyak= []
    

    for(let x=0;x<2;x++)
    {
        for(let i=0;i<kepekUrl.length;i++)
            {
                /*let uj=document.createElement("img");
                uj.src="Képek/" + kepekUrl[i];
                */
                let uj=document.createElement("div");
                uj.className="kartya"
                uj.onclick=function()
                {
                    
                    if(kattintas<2)
                    {
                        uj.style.backgroundImage="url(memoriakepek/" + kepekUrl[i]+")";
                        uj.dataset.felforditva="true"
                    }
                    console.log(kattintas);

                    kattintas++;


                    if(kattintas===2)
                    {
                        setTimeout(visszaFordit,2000);
                    }

                    
                };
                /*asztal.appendChild(uj);*/
                kartyak.push(uj)
            }
        
    }
    kartyak=kever(kartyak);

    for(let i=0;i<kartyak.length;i++)
    {
        asztal.appendChild(kartyak[i])
    }

}

function visszaFordit()
{
    const lapok=document.getElementById("asztal").children;
    console.log(lapok);
    const aktiv=[];
    for(let i=0;i<lapok.length;i++)
    {
        if(lapok[i].dataset.felforditva=="true")
        {
            aktiv.push(lapok[i]);

        }
    }
    console.log(aktiv);
    if(aktiv[0].style.backgroundImage!==aktiv[1].style.backgroundImage)
    {
        aktiv[0].style.backgroundImage="";
        aktiv[1].style.backgroundImage="";
    }
    else
    {
        //párt találtunk
        aktiv[0].onclick="";
        aktiv[1].onclick="";
        if(!vanMeg())
        {
            nyertel();
        }


    }


        aktiv[0].dataset.felforditva="";
        aktiv[1].dataset.felforditva="";

        kattintas=0;

        console.log(kattintas);

    
    
}

function vanMeg()
{
    const lapok=document.getElementById("asztal").children;
    let darab=0;
    for(let i=0;i<lapok.length;i++)
    {
        if(lapok[i].style.backgroundImage==="")
        {
            darab++
        }
    }
    return darab>0;
}
function kever(points) 
{
    for (let i = points.length -1; i > 0; i--)  
    {
        let j = Math.floor(Math.random() * (i+1));
        let k = points[i];
        points[i] = points[j];
        points[j] = k;
    }
    return points;
}

function nyertel()
{
    let uj=document.createElement("div")
    uj.innerHTML="Game Over"

    document.getElementById(asztal.appendChild(uj))
}



