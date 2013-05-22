function disable(button) {
    Page_ClientValidate();
    if (Page_IsValid) { 
        $(button).attr('disabled', 'disabled');
    }
}

function enable(button) {
    $(button).attr('disabled', false);
}

/*
$(window).load(function(){
	if ($(".flexslider").length > 0){
	    $(".flexslider").flexslider({
	        animation: "slide",
	    });
	}
});
*/

$(document).ready(function() {
    $(".alert-fade").fadeOut(5000, function(){});
    
});

$(document).ready(function() {
	if ($(".highlight").length > 0){
		$(".highlight").effect('highlight', {}, 3000);
	}
});



