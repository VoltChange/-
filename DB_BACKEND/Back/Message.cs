﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Back
{
    public class Message
    {

        public int errorCode { get; set; }

        public Dictionary<string, dynamic> data { get; set; } = new Dictionary<string, dynamic>();


        public string ReturnJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }


    public class LoginMessage : Message
    {
        public LoginMessage()
        {
            errorCode = 300;
            data.Add("loginState", false);
            data.Add("userName", null);
            data.Add("userAvatar", null);
        }
    }

    public class CheckPhoneMessage : Message
    {
        public CheckPhoneMessage()
        {
            errorCode = 300;
            data.Add("phoneunique", false);
        }
    }

    public class RegisterMessage : Message
    {
        public RegisterMessage()
        {
            errorCode = 300;
            data.Add("registerState", false);
        }
    }

    public class CustomerDetailMessage : Message
    {
        public CustomerDetailMessage()
        {
            errorCode = 400;
            data.Add("userNickName", null);
            data.Add("userAvatar", null);
            data.Add("evalNum", null);
            data.Add("userGroupLevel", null);
            data.Add("emailTag", false);
            data.Add("userScore", null);
            data.Add("registerDate", null);
            data.Add("hostCommentList", null);
            data.Add("mood", null);
            data.Add("userBirthDate", null);
            data.Add("userSex", null);
        }
    }

    public class VCcodeMessage : Message
    {
        public VCcodeMessage()
        {
            errorCode = 300;
            data.Add("sendstate", false);
        }
    }

    public class AdminMessage : Message
    {
        AdminMessage()
        {
            errorCode = 300;
            data.Add("avatar", null);
            data.Add("ID", null);
            data.Add("name", null);
        }
    }

    public class StudentInfoMessage : Message
    {
        public StudentInfoMessage()
        {
            errorCode = 400;
            data.Add("studentID", null);
            data.Add("studentName", null);
            data.Add("studentGrade", null);
            data.Add("studentMajor", null);
            data.Add("studentCredit", null);
        }
    }
    public class VerifyControllerMessage : Message
    {
        public VerifyControllerMessage()
        {
            errorCode = 300;
            data.Add("verifycode", null);
            data.Add("codeimg", null);
        }
    }

    public class ChangePasswordMessage : Message
    {
        public ChangePasswordMessage()
        {
            errorCode = 400;
            data.Add("changestate", false);
        }

    }


    public class GetStayByPageMessage : Message
    {
        public GetStayByPageMessage()
        {
            errorCode = 400;
            data.Add("examineStayList", null);
        }
    }

    public class GetStayMessage : Message
    {
        public GetStayMessage()
        {
            errorCode = 300;
            //this.data.Add("stayList", null);
        }
    }

    public class GetStayByIdMessage : Message
    {
        public GetStayByIdMessage()
        {
            errorCode = 400;
            data.Add("detailedAddress", null);
            data.Add("stayType", null);
            data.Add("stayCapability", null);
            data.Add("roomList", null);
            data.Add("publicToliet", null);
            data.Add("publicBath", null);
            data.Add("hasBarrierFree", null);
            data.Add("stayPicList", null);
        }
    }

    public class GetReportByPageMessage : Message
    {
        public GetReportByPageMessage()
        {
            errorCode = 400;
            data.Add("reportList", null);
        }
    }

    public class GetReportByIdMessage : Message
    {
        public GetReportByIdMessage()
        {
            errorCode = 400;
            data.Add("orderId", null);
            data.Add("reportTime", null);
            data.Add("reportReason", null);
            data.Add("hostId", null);
            data.Add("stayId", null);
            data.Add("hostCredit", null);
        }
    }

    public class IDVerifyMessage : Message
    {
        public IDVerifyMessage()
        {
            errorCode = 400;
            data.Add("verifyResult", 0);
            data.Add("trueName", null);
            data.Add("trueID", null);
        }
    }

    public class GetStayInfoMessage : Message
    {
        public GetStayInfoMessage()
        {
            errorCode = 300;
            data.Add("stayPositionNum", 0);
            data.Add("stayPositionInfo", null);
        }
    }

    public class GetNearByPageMessage : Message
    {
        public GetNearByPageMessage()
        {
            errorCode = 400;
            data.Add("nearbyList", null);
        }
    }

    public class UploadExamineMessage : Message
    {
        public UploadExamineMessage()
        {
            errorCode = 400;
            data.Add("isSuccess", false);
        }
    }

    public class GetStayTypeMessage : Message
    {
        public GetStayTypeMessage()
        {
            errorCode = 300;
            data.Add("typeList", null);
        }
    }


    public class GetHostInfoMessage : Message
    {
        public GetHostInfoMessage()
        {
            errorCode = 400;
            data.Add("hostAvatar", null);
            data.Add("hostNickName", null);
            data.Add("hostRealName", null);
            data.Add("hostSex", null);
            data.Add("hostLevel", null);
            data.Add("hostLevelName", null);
            data.Add("hostScore", null);
            data.Add("publishedNum", null);
            data.Add("unpublishedNum", null);
            data.Add("pendingReviewNum", null);
            data.Add("reviewNum", null);
            data.Add("emailTag", null);
            data.Add("phoneTag", null);
            data.Add("authenticationTag", null);
            data.Add("hostCreateTime", null);
            data.Add("averageRate", null);
            data.Add("unpublishedStayInfo", null);
            data.Add("pendingStayInfo", null);
            data.Add("publishedHouseInfo", null);
        }
    }

    public class StayOrderInfoMessage : Message
    {
        public StayOrderInfoMessage()
        {
            errorCode = 400;

            data.Add("averageScore", null);
            data.Add("orderInfoOfDateList", null);
            //data.Add("orderInfoOfSexList", null);
            data.Add("orderInfoOfAgeList", null);
        }
    }


    public class GetTotalNumberMessage : Message
    {
        public GetTotalNumberMessage()
        {
            errorCode = 400;
            data.Add("totalNum", 0);
        }
    }
    public class GetStayTagMessage : Message
    {
        public GetStayTagMessage()
        {
            errorCode = 300;
            data.Add("tagList", null);
        }
    }


    public class GetStayDetailsMessage : Message
    {
        public GetStayDetailsMessage()
        {
            errorCode = 400;

            data.Add("stayId", null);
            data.Add("stayImages", null);
            data.Add("stayName", null);
            data.Add("stayDescription", null);
            data.Add("characteristic", null);
            data.Add("hostAvatar", null);
            data.Add("hostLevel", null);
            data.Add("hostCommentNum", null);
            data.Add("stayPosition", null);
            data.Add("hostName", null);
            data.Add("roomNum", null);
            data.Add("bedNum", null);
            data.Add("stayCapacity", null);
            data.Add("publicBathroom", null);
            data.Add("publicToilet", null);
            data.Add("nonBarrierFacility", null);
            data.Add("startTime", null);
            data.Add("endTime", null);
            data.Add("rooms", null);
            data.Add("stayStatus", null);
        }
    }

    public class GetCommentsMessage : Message
    {
        public GetCommentsMessage()
        {
            errorCode = 400;
            data.Add("ratings", null);
            data.Add("commentNum", null);
            data.Add("comments", null);
        }
    }

    public class GetPriceMessage : Message
    {
        public GetPriceMessage()
        {
            errorCode = 400;
            data.Add("perPrice", null);
            data.Add("dateCount", null);
            data.Add("priceWithoutCoupon", null);
            data.Add("serviceFee", null);
            data.Add("couponUsage", null);
            data.Add("totalPrice", null);
        }
    }
    public class GetCustomerCouponMessage : Message
    {
        public GetCustomerCouponMessage()
        {
            errorCode = 400;
            data.Add("couponList", null);
        }
    }


    public class SearchNearMessage : Message
    {
        public SearchNearMessage()
        {
            errorCode = 400;
            data.Add("total", 0);
            data.Add("nearbyList", null);
        }
    }

    public class AddOrderMessage : Message
    {
        public AddOrderMessage()
        {
            errorCode = 400;
            data.Add("isSuccess", false);
            data.Add("payUrl", null);
            data.Add("redirectUrl", null);
            //TODO:完善


        }
    }


    public class GetStayInfosMessage : Message
    {
        public GetStayInfosMessage()
        {
            errorCode = 400;
            data.Add("stayType", null);
            data.Add("maxTenantNum", null);
            data.Add("roomNum", null);
            data.Add("bedNum", null);
            data.Add("pubRestNum", null);
            data.Add("pubBathNum", null);
            data.Add("barrierFree", null);
            data.Add("Longitude", null);
            data.Add("Latitude", null);
            data.Add("stayName", null);
            data.Add("stayChars", null);
            data.Add("startTime", null);
            data.Add("endTime", null);
            data.Add("maxDay", null);
            data.Add("minDay", null);
            data.Add("roomInfo", null);
            data.Add("stayStatus", null);
            data.Add("stayTags", null);
        }
    }
}
