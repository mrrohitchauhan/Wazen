import { Component, OnInit } from '@angular/core';
import { IDashboardBanner, IDashboardBannerResponse } from '../../models/IDashboard';
import { DashboardService } from '../../services/dashboard.service';


declare var $: any;

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
/** dashboard component*/
export class DashboardComponent implements OnInit {
  /** dashboard ctor */
  banners: IDashboardBanner[] = [];
  constructor(private _dashboardService: DashboardService) {

  }
  ngOnInit(): void {
    setTimeout(() => {
      this.owlSetup();
    })
  }

  owlSetup() {
    //faq toggle stuff
    $(".wrap-toggle").click(function (e:any) {
      e.preventDefault();
      var notthis = $(".active").not(this);
      notthis.find(".bx-minus").addClass("bx-plus").removeClass("bx-minus");
      notthis.toggleClass("active").next(".wrap-ans").slideToggle(300);
      $(this).toggleClass("active").next().slideToggle("fast");
      $(this).children("i").toggleClass("bx-plus bx-minus");
    });
    $(".partners-owl").owlCarousel({
      loop: false,
      margin: 0,
      dots: false,
      autoplay: true,
      autoPlaySpeed: 5000,
      autoPlayTimeout: 5000,
      autoplayHoverPause: true,
      nav: true,
      navText: [
        '<i class="bx bx-chevron-left"></i>',
        '<i class="bx bx-chevron-right"></i>',
      ],
      responsive: {
        0: {
          items: 1,
        },
        600: {
          items: 3,
        },
        1000: {
          items: 5,
        },
      },
    });
    // hero
    $(".bannerslider").owlCarousel({
      loop: false,
      margin: 10,
      dots: true,
      // nav: true,
      autoplay: false,
      responsive: {
        0: {
          items: 1,
        },
        600: {
          items: 1,
        },
        1000: {
          items: 1,
        },
      },
    });
    // testimonials
    $(".testimonials-slider").owlCarousel({
      loop: true,
      margin: 10,
      dots: true,
      // nav: true,
      autoplay: false,
      responsive: {
        0: {
          items: 1,
        },
        600: {
          items: 1,
        },
        1000: {
          items: 1,
        },
      },
    });
    // policies-slider
    $(".policies-slider").owlCarousel({
      loop: false,
      margin: 10,
      nav: true,
      navText: [
        "<div class='nav-btn prev-slide'><i class='bx bx-chevron-left' ></i></div>",
        "<div class='nav-btn next-slide'><i class='bx bx-chevron-right'></i></div>",
      ],
      dots: false,
      autoplay: false,
      slideBy: "page",
      responsive: {
        0: {
          items: 1,
        },
        600: {
          items: 2,
        },
        1000: {
          items: 3,
        },
      },
    });

    // sidebar
    $(function () {
      var $ul = $(".sidebar-navigation > ul");

      $ul.find("li a").click(function (e) {
        var $li = $(this).parent();

        if ($li.find("ul").length > 0) {
          e.preventDefault();

          if ($li.hasClass("selected")) {
            $li.removeClass("selected").find("li").removeClass("selected");
            $li.find("ul").slideUp(400);
            $li.find("a em").addClass("bx-plus");
          } else {
            if ($li.parents("li.selected").length == 0) {
              $ul.find("li").removeClass("selected");
              $ul.find("ul").slideUp(400);
              $ul.find("li a em").addClass("bx-plus");
            } else {
              $li.parent().find("li").removeClass("selected");
              $li.parent().find("> li ul").slideUp(400);
              $li
                .parent()
                .find("> li a em")
                .removeClass("bx-plus")
                .addClass("bx-minus");
            }

            $li.addClass("selected");
            $li.find(">ul").slideDown(400);
            $li.find(">a>em").addClass("bx-minus").removeClass("bx-plus");
          }
        }
      });
    });

    $("#datepickerInput").on("keyup changes", function () {
      //  e.attr('type' , 'date')
      console.log("asdsd");
    });
    // password
    var eye: any = document.getElementById("pass-icon");
    var coneye: any = document.getElementById("conpass-icon");
    eye.addEventListener("click", function () {
      var pass:any = document.getElementById("password");
      if (pass.type == "password") {
        pass.type = "text";
        eye.classList.add("opacity-100");
        eye.classList.remove("opacity-50");
      } else {
        pass.type = "password";
        eye.classList.remove("opacity-100");
        eye.classList.add("opacity-50");
      }
    });
    coneye.addEventListener("click", function () {
      var conpass:any = document.getElementById("conpassword");
      if (conpass.type == "password") {
        conpass.type = "text";
        coneye.classList.add("opacity-100");
        coneye.classList.remove("opacity-50");
      } else {
        conpass.type = "password";
        coneye.classList.remove("opacity-100");
        coneye.classList.add("opacity-50");
      }
    });

    // loginPassword
    var loginPasswordEye: any = document.getElementById("loginPassword-icon");
    loginPasswordEye.addEventListener("click", function () {
      var loginPassword:any = document.getElementById("loginPassword");
      if (loginPassword.type == "password") {
        loginPassword.type = "text";
        loginPasswordEye.classList.add("opacity-100");
        loginPasswordEye.classList.remove("opacity-50");
      } else {
        loginPassword.type = "password";
        loginPasswordEye.classList.remove("opacity-100");
        loginPasswordEye.classList.add("opacity-50");
      }
    });

    // OTP Form
    $("#otp-verification .form-control").keyup(function () {
      if (this.value.length == 0) {
        $(this).blur().parent().prev().children(".form-control").focus();
        $(this).blur().prev(".form-control").focus();
      } else if (this.value.length == this.maxLength) {
        $(this).blur().parent().next().children(".form-control").focus();
        $(this).blur().next(".form-control").focus();
      }
    });

    $('#datepickerInput').datepicker({
      // minDate: "+30d",
      format: "dd-mm-yyyy",
      autoclose: true,
      todayHighlight: true,
      toggleActive: true,
    }).on('changeDate', function (e) {
      var date = new Date(e.date);
      if (date) {
        var month = date.getMonth();
        month = (month + 1);
        var day = date.getDate();
        var newformattedDate = date.getFullYear() + "-" +
          month + "-" + day;
      }
    });

  }

  getBanners() {
    this._dashboardService.getBanners().subscribe((res: IDashboardBannerResponse) => {
      console.log(res);
      this.banners = res.data;
    })
  }

}
