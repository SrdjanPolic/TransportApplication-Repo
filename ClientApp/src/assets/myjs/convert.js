
var brojka,slo1,slo2,slo3,brojk,ost,slo,l_brojk,bro,bro1
var k
var flag
function number2Words(brojka) {
    slo =' '
    slo1 =' '
    slo2 =' '
    slo3 =' '

     brojk=Math.round(brojka)

        if (brojka>brojk)
            {
             ost=Math.abs((brojka-brojk)*100)
            }
            else
            {
            ost=Math.abs((brojk-brojka)*100)
            ost=100-ost
            flag = true;
            }

        ost=Math.round(ost)
        if(ost>0 && ost!= 100)
           {
          ost=String(ost);
          ost=ost.substring(0,2)
           ost=ost.replace("."," ");
          slo=slo + "  i "+ost+"/100 Din."
           }
        else {
          slo = slo + "  i   0/100 Din."
        }
        if (flag) {brojk -= 1}
       brojk=String(brojk)
       brojk="000000000" + brojk
       l_brojk=brojk.length
       brojk=brojk.substr(brojk.length-9,9)
       if( eval(brojk)==0)
         {
         slo=' Nula Din. '
         }
 for (k=0;k<=8;k++)
   {
    bro=brojk.substr(8-k,1)
       if (k==0 || k==3 || k==6 )
          {
          slo_a()
          if(k==3 && eval(brojk.substr(4,3))>0)
              {
             if (bro=="2"  || bro=="3" || bro=="4")
                {slo="hiljade"+slo }
                else if (bro == "1" || bro == "0"  || bro =="5"|| bro =="6" || bro=="7" || bro=="8" || bro== "9")
                {slo="hiljada"+slo }
              if (eval(brojk.substr(5,2))>=12 || eval(brojk.substr(5,2))<=14)
                 {slo=slo.replace("hiljade","hiljada")}

             }
            if(k==6 && eval(brojk.substr(1,3))>0)
                  {
                  if(bro=="1")
                  {
                 slo="milion"+slo
                   }
                  else if (bro > 1)
                 {
                 slo= bro.toString +"miliona"+slo
                 }
               }

          }

    if (k==1 || k==4 || k==7)
       {
        if (!(bro == "1"))
            {
            slo=slo1+slo
            slo=slo.replace("  ","")
             }
        slo_b()
        slo=slo2+slo
        }

    if (k==2 || k==5 || k==8)
       {
        slo_c()
        slo=slo3+slo
        slo=slo.replace("  ","")
        }

     slo=slo.replace("  ","")

   }

 return(slo)

}


function slo_a()
{
 if( bro=='1')
 {
 slo1='jedna'
   if( k==6)
   {
   slo1='jedan'
   }
  }
 if(bro=='2')
   {
   slo1='dve'
   if(k==6)
    {
    slo1='dva'
        }
    }
  if(bro=='3')
  {
  slo1='tri'
  }
 if ( bro=='4')
 {
 slo1='četiri'
 }
 if (bro=='5')
{
slo1='pet'
}
 if (bro=='6')
 {
 slo1='šest'
 }
if (bro=='7')
 {
 slo1='sedam'
 }
 if ( bro=='8')
 {
 slo1='osam'
 }

 if( bro=='9')
 {
 slo1='devet'
 }
 if(bro=='0')
 {
 slo1='  '
 }

 return slo1
 }

function slo_b()
 {
 if (bro=="2")
 {slo2="dvadeset"}
 if (bro=="3")
 {slo2="tridesed"}
 if (bro=="4")
 {slo2="četrdeset"}
 if (bro=="5")
 {slo2="pedeset"}
 if (bro=="6")
 {slo2="šezdeset"}
 if (bro=="7")
 {slo2="sedamdeset"}
 if (bro=="8")
 {slo2="osamdeset"}
 if (bro=="9")
 {slo2="devedeset"}
 if (bro=="0")
 {slo2="  "}
  if (bro=="1")
    {
   bro1=brojk.substr(9-k,1)
  if(bro1=="0")
  slo2="deset"
  if (bro1=="1")
 {slo2="jedanaest"}
  if (bro1=="2")
 {slo2="dvanaest"}
 if (bro1=="3")
 {slo2="trinaest"}
 if (bro1=="4")
 {slo2="četrnaest"}
 if (bro1=="5")
 {slo2="petnaest"}
 if (bro1=="6")
 {slo2="šesnaest"}
 if (bro1=="7")
 {slo2="sedamnaest"}
 if (bro1=="8")
 {slo2="osamnaest"}
 if (bro1=="9")
 {slo2="devetnaest"}
   }

  return (slo2)

}


function slo_c()
{
if (bro=='1')
 {slo3="sto"}
 if (bro=='2')
 {slo3="dvestotine"}
 if (bro=='3')
 {slo3="tristotine"}
 if (bro=='4')
 {slo3="četiristotine"}
 if (bro=='5')
 {slo3="petstotina"}
 if (bro=='6')
 {slo3="šeststotina"}
 if (bro=='7')
 {slo3="sedamstotina"}
 if (bro=='8')
 {slo3="osamstotina"}
 if (bro=='9')
 {slo3="devetstotina"}
 if (bro=='0')
 {slo3="  "}
return slo3
 }

