    //load dữ lieu lần đầu vào biểu đồ
var pageIndex = document.querySelector('input[page-index="admin-index"]');
if (pageIndex) {
    var totalChair = 1000000, totalChairVip = 5000000, total = 6000000;
    loadInfoTotal( totalChair, totalChairVip, total);


    var  two = convertPercent(totalChair, total), three = 100 - two;

    var info = [
        { label: "Ghế thường", data: two, color: "#AF4E96" },
        { label: "Ghế Vip", data: three, color: "#DA5430" }
    ];
    loadBD(info);
    //end load

    var ds = ["Trong ngày ", "Trong tuần ", "Trong tháng "];
    var text = document.getElementById('statistic');
    var btn = document.querySelectorAll('#statistical li');
    var a0, a1, a2;
    var i0, i1, i2;
    a0 = btn[0].querySelector('a');
    a1 = btn[1].querySelector('a');
    a2 = btn[2].querySelector('a');
    i0 = a0.querySelector('i');
    i1 = a1.querySelector('i');
    i2 = a2.querySelector('i');
    a0.onclick = function (e) {
        text.innerHTML = ds[0] + '<i class="icon-angle-down icon-on-right bigger-110"></i>';
        i0.classList.remove('invisible');
        i1.classList.add('invisible');
        i2.classList.add('invisible');

        a0.classList.add('blue');
        a1.classList.remove('blue');
        a2.classList.remove('blue');

        btn[0].classList.add('active');
        btn[1].classList.remove('active');
        btn[2].classList.remove('active');

        var totalChair = 10000000, totalChairVip = 5000000, total = 15000000;
        loadInfoTotal( totalChair, totalChairVip, total);

        var two = convertPercent(totalChair, total), three = 100 - ( two);
        var info = [
            { label: "Ghế thường", data: two, color: "#AF4E96" },
            { label: "Ghế Vip", data: three, color: "#DA5430" }
        ];
        loadBD(info);
    };
    a1.onclick = function (e) {
        text.innerHTML = ds[1] + '<i class="icon-angle-down icon-on-right bigger-110"></i>';
        i0.classList.add('invisible');
        i1.classList.remove('invisible');
        i2.classList.add('invisible');

        a0.classList.remove('blue');
        a1.classList.add('blue');
        a2.classList.remove('blue');

        btn[0].classList.remove('active');
        btn[1].classList.add('active');
        btn[2].classList.remove('active');


        var totalChair = 5000000, totalChairVip = 5000000, total = 10000000;
        loadInfoTotal( totalChair, totalChairVip, total);

        var  two = convertPercent(totalChair, total), three = 100 - (two);
        var info = [
            { label: "Ghế thường", data: two, color: "#AF4E96" },
            { label: "Ghế Vip", data: three, color: "#DA5430" }
        ];
        loadBD(info);
    };

    a2.onclick = function (e) {
        text.innerHTML = ds[2] + '<i class="icon-angle-down icon-on-right bigger-110"></i>';
        i0.classList.add('invisible');
        i1.classList.add('invisible');
        i2.classList.remove('invisible');

        a0.classList.remove('blue');
        a1.classList.remove('blue');
        a2.classList.add('blue');

        btn[0].classList.remove('active');
        btn[1].classList.remove('active');
        btn[2].classList.add('active');



        var totalChair = 10000000, totalChairVip = 5000000, total = 15000000;

        var  two = convertPercent(totalChair, total), three = 100 - ( two);
        loadInfoTotal(totalChair, totalChairVip, total);
        var info = [
            { label: "Ghế thường", data: two, color: "#AF4E96" },
            { label: "Ghế Vip", data: three, color: "#DA5430" }
        ];
        loadBD(info);
    };


    function loadBD(info) {
        var placeholder = $('#piechart-placeholder').css({ 'width': '90%', 'min-height': '150px' });
        var data = info;
        function drawPieChart(placeholder, data, position) {
            $.plot(placeholder, data, {
                series: {
                    pie: {
                        show: true,
                        tilt: 0.8,
                        highlight: {
                            opacity: 0.25
                        },
                        stroke: {
                            color: '#fff',
                            width: 2
                        },
                        startAngle: 2
                    }
                },
                legend: {
                    show: true,
                    position: position || "ne",
                    labelBoxBorderColor: null,
                    margin: [-30, 15]
                }
                ,
                grid: {
                    hoverable: true,
                    clickable: true
                }
            })
        }
        drawPieChart(placeholder, data);

        /**
     we saved the drawing function and the data to redraw with different position later when switching to RTL mode dynamically
        so that's not needed actually.
        */
        placeholder.data('chart', data);
        placeholder.data('draw', drawPieChart);



        var $tooltip = $("<div class='tooltip top in'><div class='tooltip-inner'></div></div>").hide().appendTo('body');
        var previousPoint = null;

        placeholder.on('plothover', function (event, pos, item) {
            if (item) {
                if (previousPoint != item.seriesIndex) {
                    previousPoint = item.seriesIndex;
                    var tip = item.series['label'] + " : " + item.series['percent'] + '%';
                    $tooltip.show().children(0).text(tip);
                }
                $tooltip.css({ top: pos.pageY + 10, left: pos.pageX + 10 });
            } else {
                $tooltip.hide();
                previousPoint = null;
            }

        });


        var d1 = [];
        for (var i = 0; i < Math.PI * 2; i += 0.5) {
            d1.push([i, Math.sin(i)]);
        }

        var d2 = [];
        for (var i = 0; i < Math.PI * 2; i += 0.5) {
            d2.push([i, Math.cos(i)]);
        }

        var d3 = [];
        for (var i = 0; i < Math.PI * 2; i += 0.2) {
            d3.push([i, Math.tan(i)]);
        }


        //Android's default browser somehow is confused when tapping on label which will lead to dragging the task
        //so disable dragging when clicking on label
        var agent = navigator.userAgent.toLowerCase();
        if ("ontouchstart" in document && /applewebkit/.test(agent) && /android/.test(agent))
            $('#tasks').on('touchstart', function (e) {
                var li = $(e.target).closest('#tasks li');
                if (li.length == 0) return;
                var label = li.find('label.inline').get(0);
                if (label == e.target || $.contains(label, e.target)) e.stopImmediatePropagation();
            });
    };
    function loadInfoTotal( totalChair, totalChairVip, total) {
        let  b, c, d;
        b = document.getElementById('totalChair');
        c = document.getElementById('totalChairVip');
        d = document.getElementById('total');
        b.textContent = formatNumber(totalChair, '.', ',');
        c.textContent = formatNumber(totalChairVip, '.', ',');
        d.textContent = formatNumber(total, '.', ',');
    }
    function formatNumber(nStr, decSeperate, groupSeperate) {
        nStr += '';
        x = nStr.split(decSeperate);
        x1 = x[0];
        x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;
        while (rgx.test(x1)) {
            x1 = x1.replace(rgx, '$1' + groupSeperate + '$2');
        }
        return x1 + x2;
    }
    function convertPercent(element, sum) {
        var per = element / sum;
        return (Math.round(per * 100) / 100).toFixed(2) * 100;
    }
}
   
    