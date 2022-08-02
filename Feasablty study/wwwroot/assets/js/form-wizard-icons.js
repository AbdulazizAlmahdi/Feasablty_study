/**
 *  Form Wizard
 */

'use strict';

$(function () {
  const select2 = $('.select2'),
    selectPicker = $('.selectpicker');

  // Bootstrap select
  if (selectPicker.length) {
    selectPicker.selectpicker();
  }

  // select2
  if (select2.length) {
    select2.each(function () {
      var $this = $(this);
      $this.wrap('<div class="position-relative"></div>');
      $this.select2({
        placeholder: 'Select value',
        dropdownParent: $this.parent()
      });
    });
  }
});

(function () {
  // Icons Wizard
  // --------------------------------------------------------------------
  const wizardIcons = document.querySelector('.wizard-icons-example');

  if (typeof wizardIcons !== undefined && wizardIcons !== null) {
    const wizardIconsBtnNextList = [].slice.call(wizardIcons.querySelectorAll('.btn-next')),
      wizardIconsBtnPrevList = [].slice.call(wizardIcons.querySelectorAll('.btn-prev')),
      wizardIconsBtnSubmit = wizardIcons.querySelector('.btn-submit');
      

    const iconsStepper = new Stepper(wizardIcons, {
      linear: false
    });
    if (wizardIconsBtnNextList) {
      wizardIconsBtnNextList.forEach(wizardIconsBtnNext => {
        wizardIconsBtnNext.addEventListener('click', event => {
          iconsStepper.next();
        });
      });
    }
    if (wizardIconsBtnPrevList) {
      wizardIconsBtnPrevList.forEach(wizardIconsBtnPrev => {
        wizardIconsBtnPrev.addEventListener('click', event => {
          iconsStepper.previous();
        });
      });
    }
    if (wizardIconsBtnSubmit) {
      wizardIconsBtnSubmit.addEventListener('click', event => {
        alert('تم الارسال..!!');
      });
    }
  }

  // Vertical Icons Wizard
  // --------------------------------------------------------------------
  const wizardIconsVertical = document.querySelector('.wizard-vertical-icons-example');

  if (typeof wizardIconsVertical !== undefined && wizardIconsVertical !== null) {
    const wizardIconsVerticalBtnNextList = [].slice.call(wizardIconsVertical.querySelectorAll('.btn-next')),
      wizardIconsVerticalBtnPrevList = [].slice.call(wizardIconsVertical.querySelectorAll('.btn-prev')),
      wizardIconsVerticalBtnSubmit = wizardIconsVertical.querySelector('.btn-submit');

    const verticalIconsStepper = new Stepper(wizardIconsVertical, {
      linear: false
    });

    if (wizardIconsVerticalBtnNextList) {
      wizardIconsVerticalBtnNextList.forEach(wizardIconsVerticalBtnNext => {
        wizardIconsVerticalBtnNext.addEventListener('click', event => {
          verticalIconsStepper.next();
        });
      });
    }
    if (wizardIconsVerticalBtnPrevList) {
      wizardIconsVerticalBtnPrevList.forEach(wizardIconsVerticalBtnPrev => {
        wizardIconsVerticalBtnPrev.addEventListener('click', event => {
          verticalIconsStepper.previous();
        });
      });
    }
    if (wizardIconsVerticalBtnSubmit) {
      wizardIconsVerticalBtnSubmit.addEventListener('click', event => {
        alert('Submitted..!!');
      });
    }
  }

  // Icons Modern Wizard
  // --------------------------------------------------------------------
  const wizardIconsModern = document.querySelector('.wizard-modern-icons-example');

  if (typeof wizardIconsModern !== undefined && wizardIconsModern !== null) {
    const wizardIconsModernBtnNextList = [].slice.call(wizardIconsModern.querySelectorAll('.btn-next')),
      wizardIconsModernBtnPrevList = [].slice.call(wizardIconsModern.querySelectorAll('.btn-prev')),
      wizardIconsModernBtnSubmit = wizardIconsModern.querySelector('.btn-submit');

    const modernIconsStepper = new Stepper(wizardIconsModern, {
      linear: false
    });

    if (wizardIconsModernBtnNextList) {
      wizardIconsModernBtnNextList.forEach(wizardIconsModernBtnNext => {
        wizardIconsModernBtnNext.addEventListener('click', event => {
          modernIconsStepper.next();
        });
      });
    }
    if (wizardIconsModernBtnPrevList) {
      wizardIconsModernBtnPrevList.forEach(wizardIconsModernBtnPrev => {
        wizardIconsModernBtnPrev.addEventListener('click', event => {
          modernIconsStepper.previous();
        });
      });
    }
    if (wizardIconsModernBtnSubmit) {
      wizardIconsModernBtnSubmit.addEventListener('click', event => {
        alert('Submitted..!!');
      });
    }
  }

  // Icons Modern Wizard
  // --------------------------------------------------------------------
  const wizardIconsModernVertical = document.querySelector('.wizard-modern-vertical-icons-example');

  if (typeof wizardIconsModernVertical !== undefined && wizardIconsModernVertical !== null) {
    const wizardIconsModernVerticalBtnNextList = [].slice.call(wizardIconsModernVertical.querySelectorAll('.btn-next')),
      wizardIconsModernVerticalBtnPrevList = [].slice.call(wizardIconsModernVertical.querySelectorAll('.btn-prev')),
      wizardIconsModernVerticalBtnSubmit = wizardIconsModernVertical.querySelector('.btn-submit');

    const verticalModernIconsStepper = new Stepper(wizardIconsModernVertical, {
      linear: false
    });

    if (wizardIconsModernVerticalBtnNextList) {
      wizardIconsModernVerticalBtnNextList.forEach(wizardIconsModernVerticalBtnNext => {
        wizardIconsModernVerticalBtnNext.addEventListener('click', event => {
          verticalModernIconsStepper.next();
        });
      });
    }
    if (wizardIconsModernVerticalBtnPrevList) {
      wizardIconsModernVerticalBtnPrevList.forEach(wizardIconsModernVerticalBtnPrev => {
        wizardIconsModernVerticalBtnPrev.addEventListener('click', event => {
          verticalModernIconsStepper.previous();
        });
      });
    }
    if (wizardIconsModernVerticalBtnSubmit) {
      wizardIconsModernVerticalBtnSubmit.addEventListener('click', event => {
        alert('Submitted..!!');
      });
    }
  }
})();




// --------------------------------


//-----------------------------------------------------------------


  //--------------------------------الكود حق جدول تحليل المنافسين-----------------------------------------------
 

///////////////////////////////////////////////////////////////////

function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function addlicense()
	{ 
	var table = document.getElementById("LicenseType");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+1;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = ' <input type="text" name="license" class="form-control" />'; 
 cell3.innerHTML = ' <input type="text" name="hand" class="form-control" />'; 
cell4.innerHTML = '  <input type="button" class="btn btn-block btn-default" id="add-row" onclick="deleteRow(\''+id+'\')"  ><i class="bx bx-trash me-1"></i> </input> '; 
 }

//اول جدوال في الدراسة السوقيه تحليل المنافسين

function deleteRow(id) 
{
	document.getElementById(id).remove() 
}
function childTable()
{ 
        var table = document.getElementById("childTable");
	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = ' <input type="text" name="name" class="form-control" />'; 
 cell3.innerHTML = ' <input type="text" name="school" class="form-control" />'; 
 cell4.innerHTML = ' <input type="text" name="year" class="form-control" />'; 
 cell5.innerHTML = ' <input type="text" name="age" class="form-control" />'; 
 cell6.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
}

 
//  جدول الايرادات المتوقعة   
function calculateTotalB()
{

 var table1 = document.getElementById("Revenuerow").getElementsByTagName("tbody")[0];
 var rows=table1.getElementsByTagName("tr");
 var i;
 var ii;
 var PriceQuality=0;
 var price,Quality;
 var total=0;
 var TotalQuality=0;
 var TotalPrice=0;
 var totalBox5=document.getElementById("totalmonthly");
 var totalBox=document.getElementById("totalall");


 for (i=0;i<rows.length;i++)
 {

   for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
   {
    Quality=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);
    price=(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);

    PriceQuality=price*Quality;
   rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value=PriceQuality;
   rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value=PriceQuality*12;

   
 }
 TotalQuality=TotalQuality+Number(Quality);
 TotalPrice=TotalPrice+Number(price);
document.getElementById("qualite").value=TotalQuality;
document.getElementById("price").value=TotalPrice;
total=total+Number(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);
totalBox5.value=total;
 total=total+Number(rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value);
   totalBox.value=total;
}

}

 
function deleteRow(id) 
{
	document.getElementById(id).remove() 
	}
function Revenuerow()
	{ 
	var table = document.getElementById("Revenuerow");
 
  

	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+1;
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
 var cell7 = row.insertCell(6);


 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="name" class="form-control" placeholder="اسم الصنف"/>  '; 
 cell3.innerHTML = ' <input type="number" name="quality" class="form-control" min="0" max="1000" placeholder="00" onkeyup="calculateTotalB()"/>'; 
 cell4.innerHTML = ' <input  type="number" name="priceUnit" class="form-control"  min="0" max="1000" placeholder="000" onkeyup="calculateTotalB()"/>'; 
 cell5.innerHTML = ' <input disabled type="number" name="totalMoth" class="form-control"  min="0" max="1000" placeholder="0000" />';
 cell6.innerHTML = ' <input disabled type="number" name="totalyear" class="form-control"  min="0" max="1000" placeholder="0000000"/>';  
 cell7.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
}
 
 // السوقيه الخطة التسوقيه
 function calcualteTotalA()
 {
  
  
  var table1 = document.getElementById("ch").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var Activ=0;
  var TotalActiv=0;
  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      Activ=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);


    rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value=Activ;
    
  }
  TotalActiv=TotalActiv+Number(Activ);
  document.getElementById("Activ").value=TotalActiv;
  
}

 }



 function deleteRow(id) 
 {
   document.getElementById(id).remove() 
   } function ch()
   { 
   var table = document.getElementById("ch");
   // GET TOTAL NUMBER OF ROWS 
 var y =table.rows.length; 
 var id = "tbl"+y+3;
  
 var row = table.insertRow(y); 
 row.id=id;
  var cell1 = row.insertCell(0); 
  var cell2 = row.insertCell(1); 
  var cell3 = row.insertCell(2); 
 
  var cell4 = row.insertCell(3);
  cell1.outerHTML = `<th> ${y}</th>`; 
  cell2.innerHTML = '<input type="text" name="Activ" class="form-control" placeholder="النشاط"/>'; 
  cell3.innerHTML = '<input type="number" name="mony" class="form-control" placeholder="00000"  onkeyup="calcualteTotalA()"/> '; 
  cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
  }
 
 
 //الجدوال الثالث في الدراسة السوقيه اداة المخاطر
 
 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function riskmanage()
	{ 
	var table = document.getElementById("riskmanage");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+4;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = '<input type="text" name="Foundation" class="form-control" placeholder="نوع الخطر  "/>  '; 
 cell3.innerHTML = '<input type="text" name="price" class="form-control" placeholder="شرح الخطر" "/> '; 
 cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 ///////////////////////////////////////////////////////
 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function DangerStyle()
	{  
	var table = document.getElementById("DangerStyle");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+5;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = '<input type="text" name="dangertype" class="form-control" placeholder="اسلوب الخطر"/>'; 
 cell3.innerHTML = '<input type="text" name="dangerExplain" class="form-control" placeholder="شرح الاسلوب"/>'; 
 cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 //اول جدوال في الدراسة الفنية الاثاث والمعدات
  function calculateTotal()
 {
  
  
  var table1 = document.getElementById("Furniture").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var PricesAmount=0;
  var prices,Amount;
  var total=0;
  var TotalPrices=0;
  var Totalamount=0;
  var totalBox=document.getElementById("totalas");

  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
    Amount=(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);
    prices=(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);

    PricesAmount=Amount*prices;

    rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value=PricesAmount;
    
  }
  TotalPrices=TotalPrices+Number(prices);
  Totalamount=Totalamount+Number(Amount);
  document.getElementById("prices").value=TotalPrices;
  document.getElementById("amount").value=Totalamount;
  total=total+Number(rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value);
    totalBox.value=total;
}

 }

 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} 
function Furniture()
	{ 
    var table = document.getElementById("Furniture");
    calculateTotal();

	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+5; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
 var cell7 = row.insertCell(6);
 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="item" class="form-control"  placeholder=" البنـــــــد"/>  '; 
 cell3.innerHTML = '<input type="text" name="supplier" class="form-control" placeholder="اسم المورد"/>  '; 
 cell4.innerHTML = '<input type="number" name="total" class="form-control" placeholder="00" onkeyup=\'calculateTotal();\'/> '; 
 cell5.innerHTML = '<input type="number" name="price" class="form-control" placeholder="0000"/ onkeyup=\'calculateTotal();\'/> '; 
  cell6.innerHTML = '<input disabled type="number" name="totals" class="form-control" placeholder="0000000"/>  '; 
  cell7.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
}
 
 
 //جدوال القوى العاملة للمشروع    
 function calculateTotala()
 {
 
  var table1 = document.getElementById("staffs").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var MonysNemployee=0;
  var nemployee,Monys;
  var total=0;
  var TotalNemployee=0;
  var Totalmonys=0;
  var totalBox=document.getElementById("totalsyears");
  var totalBox1=document.getElementById("totalMony");


  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      Monys=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);
      nemployee=(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);

      MonysNemployee=Monys*nemployee;
    rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value=MonysNemployee;
    rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value=MonysNemployee*12;

    
  }
  TotalNemployee=TotalNemployee+Number(nemployee);
  Totalmonys=Totalmonys+Number(Monys);
 document.getElementById("Nemployee").value=TotalNemployee;
 document.getElementById("monys").value=Totalmonys;
 total=total+Number(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);
 totalBox1.value=total;
  total=total+Number(rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value);
    totalBox.value=total;
}

 }

 function deleteRow(id) 
{
	document.getElementById(id).remove() 
  } 
function staffs()
	{ 
  var table = document.getElementById("staffs");
  
	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+6; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
   var cell7 = row.insertCell(6);
 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="occupation" class="form-control" placeholder="اسم الوظيفة "/>  '; 
 cell3.innerHTML = '<input type="number" name="monys" class="form-control" placeholder="0000" onkeyup=\'calculateTotala();\'/> '; 
 cell4.innerHTML = '<input type="number" name="Nemployee" class="form-control" placeholder="0" onkeyup=\'calculateTotala();\'/>  ';
 cell5.innerHTML = '<input disabled type="number" name="totalMony" class="form-control" placeholder="0000"/>  '; 
 cell6.innerHTML = '<input disabled type="number" name="totalMony" class="form-control" placeholder="0000000"/>  '; 
 cell7.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 
  //جدوال الانشات والمباني 
  function calculateTablll()
 {
 
  var table1 = document.getElementById("Buildings").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var MaterArea=0;
  var mater,Area;
  var total=0;
  var totalBox=document.getElementById("Totalsa");

  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      mater=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);
      Area=(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);

      MaterArea=mater*Area;
    console.log(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);
    rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value=MaterArea;
    
  }
  total=total+Number(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);
    totalBox.value=total;
}

 }
  
 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function Buildings()
	{ 
  var table = document.getElementById("Buildings");
  
 
	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+7; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="Builid" class="form-control" placeholder="نوع البناء  "/>'; 
 cell3.innerHTML = '<input type="number" name="Mater" class="form-control" placeholder="000" onkeyup="calculateTablll();"/>'; 
 cell4.innerHTML = '<input type="number" name="Area" class="form-control" placeholder="000" onkeyup="calculateTablll();"/>'; 
 cell5.innerHTML = '<input disabled type="number" name="Totalsa" class="form-control" placeholder="000"/> ';
 cell6.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 
 
  //جدوال الايجارات
  function calculateTotall()
 {
  
  
  var table1 = document.getElementById("rentals").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var rentAnnually=0;
  var TotalAnnully=0;
  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      rentAnnually=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);


    rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value=rentAnnually;
    
  }
  TotalAnnully=TotalAnnully+Number(rentAnnually);
  document.getElementById("rentAnnually").value=TotalAnnully;
  
}

 }

 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function rentals()
	{ 
  var table = document.getElementById("rentals");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+8;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = '<input type="text" name="varieties" class="form-control" placeholder=" الاصناف والمعدات"/> '; 
 cell3.innerHTML = '<input type="number" name="rentAnnually" class="form-control" placeholder="000" onkeyup="calculateTotall()"/> '; 
 cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 
 
 //جدوال  الرسوم الحكومية والضرائب 
 function calculateTotalX()
 {
  
  
  var table1 = document.getElementById("Taxes").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var AnnualFee=0;
  var TotalAnnualFee=0;
  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      AnnualFee=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);


    rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value=AnnualFee;
    
  }
  TotalAnnualFee=TotalAnnualFee+Number(AnnualFee);
  document.getElementById("AnnualFee").value=TotalAnnualFee;
  
}

 }
 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function Taxes()
	{ 
	var table = document.getElementById("Taxes");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+9;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = '<input type="text" name="fees" class="form-control" placeholder="الرسوم الحكومية "/>  '; 
 cell3.innerHTML = '<input type="number" name="AnnualFee" class="form-control" placeholder="0000"  onkeyup="calculateTotalX();"/> '; 
 cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }

  //مصاريف التأسيس     

 function calculateTotalXX()
 {
  
  
  var table1 = document.getElementById("TTT").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var AnnualFeeE=0;
  var TotalAnnualFeeE=0;
  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      AnnualFeeE=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);


    rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value=AnnualFeeE;
    
  }
  TotalAnnualFeeE=TotalAnnualFeeE+Number(AnnualFeeE);
  document.getElementById("AnnualFeeE").value=TotalAnnualFeeE;
  
}

 }


 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function TTT()
	{ 
	var table = document.getElementById("TTT");
	// GET TOTAL NUMBER OF ROWS 
var y =table.rows.length; 
var id = "tbl"+y+10;
 
var row = table.insertRow(y); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 

 var cell4 = row.insertCell(3);
 cell1.outerHTML = `<th> ${y}</th>`; 
 cell2.innerHTML = '<input type="text" name="fees" class="form-control" placeholder="مصاريف التأسيس  "/>  '; 
 cell3.innerHTML = '<input type="number" name="AnnualFeeeE" class="form-control" placeholder="0000"  onkeyup="calculateTotalXX();"/> '; 
 cell4.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 
   //جدوال  المواد الخام 
 
 function calculateTota()
 {
 
  var table1 = document.getElementById("Materials").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var UintReqired=0;
  var Uint,Reqired;
  var total=0;
  var Totalunit=0;
  var TotalReqired=0;
  var totalBox1=document.getElementById("totalss");
  var totalBox=document.getElementById("totalsss");


  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      Uint=(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);
      Reqired=(rows[i].getElementsByTagName("td")[3].getElementsByTagName("input")[0].value);

      UintReqired=Uint*Reqired;
    rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value=UintReqired;
    rows[i].getElementsByTagName("td")[5].getElementsByTagName("input")[0].value=UintReqired*12;

    
  }
  Totalunit=Totalunit+Number(Uint);
  TotalReqired=TotalReqired+Number(Reqired);
 document.getElementById("uints").value=Totalunit;
 document.getElementById("qualitReqiredMonthly").value=TotalReqired;
 total=total+Number(rows[i].getElementsByTagName("td")[4].getElementsByTagName("input")[0].value);
 totalBox1.value=total;
  total=total+Number(rows[i].getElementsByTagName("td")[5].getElementsByTagName("input")[0].value);
    totalBox.value=total;
}

 }
 //////////////////////////////////

 function deleteRow(id) 
{
	document.getElementById(id).remove() 
  } 
  function Materials()
	{ 
  var table = document.getElementById("Materials");
 
 
	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+11; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
 var cell5 = row.insertCell(4);
 var cell6 = row.insertCell(5);
 var cell7 = row.insertCell(6);
 var cell8 = row.insertCell(7);

 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="Article" class="form-control" placeholder="نوع الماده"/> '; 
 cell3.innerHTML = '<input type="text" name="liter" class="form-control" placeholder="لتر"/> '; 
 cell4.innerHTML = '<input type="number" name="Uint" class="form-control" placeholder="00" onkeyup="calculateTota()"/> '; 
 cell5.innerHTML = '<input type="number" name="qualitReqiredMonthly" class="form-control" placeholder="000" onkeyup="calculateTota()"/> ';
 cell6.innerHTML = '<input disabled type="number" name="totalss" class="form-control" placeholder="00000"/> ';
 cell7.innerHTML = '<input disabled type="number" name="totalsss" class="form-control" placeholder="000000"/> ';
 cell8.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 // المنافع العامة
 function calculateTot()
 {
 
  var table1 = document.getElementById("benefits").getElementsByTagName("tbody")[0];
  var rows=table1.getElementsByTagName("tr");
  var i;
  var ii;
  var Monthlycost=0;
  var total=0;
  var TotalMonthlycost=0;
  var totalBox=document.getElementById("yearcost");

  for (i=0;i<rows.length;i++)
  {

    for(ii=0;ii<=rows[i].getElementsByTagName("td").length;ii++)
    {
      Monthlycost=(rows[i].getElementsByTagName("td")[1].getElementsByTagName("input")[0].value);

      Monthlycost=Monthlycost;
    console.log(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);
    rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value=Monthlycost;
    rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value=Monthlycost*12;

    
  }
  TotalMonthlycost=TotalMonthlycost+Number(Monthlycost);
  document.getElementById("Monthlycost").value=TotalMonthlycost;
  total=total+Number(rows[i].getElementsByTagName("td")[2].getElementsByTagName("input")[0].value);
    totalBox.value=total;
}
 }


 function deleteRow(id) 
{
	document.getElementById(id).remove() 
	} function benefits()
	{ 
  var table = document.getElementById("benefits");
  
 
	// GET TOTAL NUMBER OF ROWS 
var x =table.rows.length; 
var id = "tbl"+x+12; 
var row = table.insertRow(x); 
row.id=id;
 var cell1 = row.insertCell(0); 
 var cell2 = row.insertCell(1); 
 var cell3 = row.insertCell(2); 
 var cell4 = row.insertCell(3);
  var cell5 = row.insertCell(4);
 cell1.outerHTML = `<th> ${x}</th>`; 
 cell2.innerHTML = '<input type="text" name="item" class="form-control" placeholder="الماده   "/>'; 
 cell3.innerHTML = '<input type="number" name="Monthlycost" class="form-control" placeholder="00000" onkeyup="calculateTot()"/>'; 
 cell4.innerHTML = '<input disabled type="number" name="yearcost" class="form-control" placeholder="0000000"/>'; 
 cell5.innerHTML = '  <button type="button" class="btn btn-danger" class=btn btn-primary" id="add-row" onclick="deleteRow(\''+id+'\')"> حذف</button> '; 
 }
 
 //////////////////////////////////////////////////////////////////////////////////
 ///////////////////////////////////////////////////////////////////
 var isvalid=true;
$( document ).ready(function() {
    $("#test").prop("disabled",true);
    $(".tabbody input[type=number]").blur(function(){
        validateSubmit();
    });
});
function validateSubmit()
{
    var retval = sumRowVals();
    $("#test").prop("disabled",!retval);
    $("#msgdiv").html(retval ? "":"Invalid inputs!!!");
}
function sumRowVals()
{
    isvalid=true;
    resetFigs();
    var rindx=1;
    $(".tabbody tr").each(function(){
        var temp=0;
        var cindx=1;
        $("input[type=number]",this).each(function(){
            var elval = !isNaN($(this).val()) ? parseInt($(this).val()):0;
            var sumcol = $("#ccol"+cindx);
            $(sumcol).html(parseInt($(sumcol).html())+elval);
            temp=temp+elval;
            cindx++;
            if(elval > 100){isvalid=false;}
            if(parseInt($(sumcol).html()) > 100){isvalid=false;}
        });
        if(rindx != $('.tabbody tr').length)
        {
            if(temp != 100){isvalid=false;}
            $("#rcol"+rindx).html(temp);
        }
        rindx++;
    });
    return isvalid;
}
function resetFigs()
{
    $('*[id*=ccol]').each(function() {
    $(this).html("0");
});
}
function SubmitForm()
{
    // your form submit code
}