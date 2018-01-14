
// $(document).ready(function(){
//
//
// 	/* ---- Countdown timer ---- */
//
// 	$('#counter').countdown({
// 		timestamp : (new Date()).getTime() + 11*24*60*60*1000
// 	});
//
//
// 	/* ---- Animations ---- */
//
// 	$('#links a').hover(
// 		function(){ $(this).animate({ left: 3 }, 'fast'); },
// 		function(){ $(this).animate({ left: 0 }, 'fast'); }
// 	);
//
// 	$('footer a').hover(
// 		function(){ $(this).animate({ top: 3 }, 'fast'); },
// 		function(){ $(this).animate({ top: 0 }, 'fast'); }
// 	);
//
//
//
//
//
//
// });


function saveComment() {
    var name = $("#name").val();
    var detail = $("#detail").val();
    var product_id = $("#product_id").val();
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }
    var today = dd + '/' + mm + '/' + yyyy;

    $.ajax({
        url: "/comment/add",
        type: "POST",
        dataType: "json",
        data: { name: name, detail: detail, product_id: product_id },
        success: function () {

            var trHtml = '<div class="additional_info_sub_grids">'
            + '<div class="col-xs-2 additional_info_sub_grid_left">'
            + '</div>'
            + '<div class="col-xs-10 additional_info_sub_grid_right">'
            + '<div class="additional_info_sub_grid_rightl">'
            + '<a href="single.html">' + name + '</a>'
            + '<h5>' + today + '</h5>'
            + '<p>' + detail + '</p>'
            + '</div>'
            + '<div class="additional_info_sub_grid_rightr">'
            + '<div class="rating">'
            + '<div class="rating-left">'
            + '<img src="~/Content/Image/star-.png" alt=" " class="img-responsive">'
            + '</div>'
            + '<div class="rating-left">'
            + '<img src="~/Content/Image/star-.png" alt=" " class="img-responsive">'
            + '</div>'
            + '<div class="rating-left">'
            + '<img src="/images/star.png" alt=" " class="img-responsive">'
            + '</div>'
            + '<div class="rating-left">'
            + '<img src="/images/star.png" alt=" " class="img-responsive">'
            + '</div>'
            + '<div class="rating-left">'
            + '<img src="/images/star.png" alt=" " class="img-responsive">'
            + '</div>'
            + '<div class="clearfix"> </div>'
            + '</div>'
            + '</div>'
            + '<div class="clearfix"> </div>'
            + '</div>'
            + '<div class="clearfix"> </div>'
            + '</div>"';

            $('#comment').append(trHtml);
        }
    })
}

function check_pass() {
    if (document.getElementById('create_password').value ==
        document.getElementById('confirm_password').value) {
        document.getElementById('create_account').disabled = false;
        document.getElementById('notify').innerHTML = "";
    } else {
        document.getElementById('create_account').disabled = true;
        if (document.getElementById('confirm_password').value != "")
            document.getElementById('notify').innerHTML = "Mật khẩu nhập lại không khớp";
    }
}

function show_comment(id) {


    var skip = $("#more").attr('name');

    $.ajax({
        url: "/comment/" + id + "/" + skip,
        type: "GET",
        success: function (data) {
            for (var i = 0; i < data.length; i++) {

                var trHtml = '<div class="additional_info_sub_grids">' +
                    '<div class="col-xs-2 additional_info_sub_grid_left">' +
                    '</div>' +
                    '<div class="col-xs-10 additional_info_sub_grid_right">' +
                    '<div class="additional_info_sub_grid_rightl">' +
                    '<a href="single.html">' +
                    data[i].name +
                    '</a>' +
                    '<h5>' +
                    data[i].date +
                    '</h5>' +
                    '<p>' +
                    data[i].detail +
                    '</p>' +
                    '</div>' +
                    '<div class="additional_info_sub_grid_rightr">' +
                    '<div class="rating">' +
                    '<div class="rating-left">' +
                    '<img src="~/Content/Image/star-.png" alt=" " class="img-responsive">' +
                    '</div>' +
                    '<div class="rating-left">' +
                    '<img src="~/Content/Image/star-.png" alt=" " class="img-responsive">' +
                    '</div>' +
                    '<div class="rating-left">' +
                    '<img src="/images/star.png" alt=" " class="img-responsive">' +
                    '</div>' +
                    '<div class="rating-left">' +
                    '<img src="/images/star.png" alt=" " class="img-responsive">' +
                    '</div>' +
                    '<div class="rating-left">' +
                    '<img src="/images/star.png" alt=" " class="img-responsive">' +
                    '</div>' +
                    '<div class="clearfix"> </div>' +
                    '</div>' +
                    '</div>' +
                    '<div class="clearfix"> </div>' +
                    '</div>' +
                    '<div class="clearfix"> </div>' +
                    '</div>';
                $('#comment').append(trHtml);
            }


            if (data.length != 0) {
                $("#more").attr('name', parseInt(skip) + 10);
            } else {
                $("#more").hide();
            }
        }
    });
}

function get_product(product_type, manufacturer, price,page) {
    $.ajax(
        {
            url: "/home/product?type=" + product_type +"&manufacturer=" +manufacturer+"&price=" +price+"&page=" + page,
            type: "GET",
            success: function (data) {
                var json = JSON.parse(data);
                
                if (json.length == 0) {
                    var type = $('.category.active').find('a').attr('href');
                    $('.producttype' + type).find('.moreproduct').remove();
                    return;
                }

                var type = $('.category.active').find('a').attr('href');
                if (page == 0) {
                    $('.producttype' + type).find('.agile_ecommerce_tabs').find('.col-md-4.agile_ecommerce_tab_left').remove();
                }
                for (var i = 0; i < json.length; i++) {
                    var html = '<div class="col-md-4 agile_ecommerce_tab_left">' +
                        '<div class="hs-wrapper">' +
                        '  <img src="'+json[i].Image+'" alt=" " class="img-responsive"/>' +
                        '<img src="' + json[i].Image + '" alt=" " class="img-responsive"/>' +
                        '<img src="' + json[i].Image + '" alt=" " class="img-responsive"/>' +
                        '<img src="' + json[i].Image + '" alt=" " class="img-responsive"/>' +
                        '<img src="' + json[i].Image + '" alt=" " class="img-responsive"/>' +
                        '<img src="' + json[i].Image + '" alt=" " class="img-responsive"/>' +
                        '<div class="w3_hs_bottom">' +
                        '<ul>' +
                        '<li>' +
                        ' <a href="#" data-toggle="modal" data-target="#p'+json[i].Id+'"><span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span></a>' +
                        '  </li>' +
                        '</ul>' +
                        '</div>' +
                        '</div >' +
                        '<h5><a href="/detail/@product.Id">'+json[i].Name+'</a></h5>' +
                        '<div class="simpleCart_shelfItem">' +
                        '  <p>' +
                        '    <i class="item_price">' + json[i].Price + '</i>' +
                        '</p>' +
                        '<form action="#" method="post">' +
                        '  <input type="hidden" name="id" value="' + json[i].Id + '"/>' +
                        '<input type="hidden" name="cmd" value="_cart"/>' +
                        '<input type="hidden" name="add" value="1"/>' +
                        '<input type="hidden" name="w3ls_item" value="' + json[i].Name + '"/>' +
                        '<input type="hidden" name="amount" value="' + json[i].Price + '"/>' +
                        '<button type="submit" class="w3ls-cart">Mua</button>' +
                        '</form>' +
                        '</div>' +
                        '</div>';


                    var type = $('.category.active').find('a').attr('href');
                   
                    $('.producttype' + type).find('.agile_ecommerce_tabs').append(html);
                    var value = $('.producttype' + type).find('.moreproduct').attr('onclick');
                    var next = page + 1;
                    value = "get_product(" + product_type + "," + manufacturer + "," + price + "," + next + ")";
                    $('.producttype' + type).find('.moreproduct').attr('onclick', value);

                  
                }
            },
            error: function () {
                alert("fail");
            }
        }
    );
}
function get_type_active() {
    return $('.category.active').find('a').attr('href').substr(1);
}

function show_login_form() {
    $("#myModal88").modal('show');
}
function subcribed(){
    $('.subcribe_button').css('background', '#205AA7');
    var tag = $('.subcribe_button').find('span');
    tag.find('span:first').text('SUBCRIBED');
    var subcriber = tag.find('span:last');
    var num = Number(subcriber.text());
    num++;
    subcriber.text(num);
    $('.subcribe_button').attr('onclick', 'unsubscribe()');
}
function subcribe() {
    $.ajax({
        url: "/member/subcribe",
        type: "GET",
        success: function (data) {
            subcribed();
        },
        error: function () {
            alert("sub");
        }
    })
}

function get_subcriber() {
    $.ajax({
        url: "/home/subcriber",
        type: "GET",
        success: function (data) {
            
            var tag = $('.subcribe_button').find('span');
            var subcriber = tag.find('span:last');
            var num = data;
            subcriber.text(num);
        },
        error: function () {
            alert("get_sub");
        }
    })
}

function is_subcribed() {
    $.ajax({
        url: "/member/subscribed",
        type: "GET",
        success: function (data) {
            if (data == true) {
                $('.subcribe_button').css('background', '#205AA7');
                $('.subcribe_button').attr('onclick', 'unsubscribe()');

                var tag = $('.subcribe_button').find('span');
                tag.find('span:first').text('SUBCRIBED');

            }
        },
        error: function () {
            alert("is_sub");
        }
    })

}

function unsubscribe() {
    $.ajax({
        url: "/member/unsubcribe",
        type: "GET",
        success: function (data) {
            unsubscribed();
        },
        error: function () {
            alert("un_sub");
        }
    })
}

function unsubscribed() {
    $('.subcribe_button').css('background', 'red');
    var tag = $('.subcribe_button').find('span');
    tag.find('span:first').text('SUBCRIBE');
    var subcriber = tag.find('span:last');
    var num = Number(subcriber.text());
    num--;
    subcriber.text(num);
    $('.subcribe_button').attr('onclick', 'subcribe()');
}
