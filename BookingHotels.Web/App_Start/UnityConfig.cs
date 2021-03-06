﻿using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using BookingHotels.BLL.Interfaces;
using BookingHotels.BLL.Services;
using BookingHotels.Domain.Interfaces;
using BookingHotels.DAL.Repositories;

namespace BookingHotels.Web
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<IHotelService, HotelService>();
			container.RegisterType<IRoomService, RoomService>();
			container.RegisterType<IUserService, UserService>();
			container.RegisterType<IBookingService, BookingService>();
			container.RegisterType<IRoomImageService, RoomImageService>();
			container.RegisterType<IFeedbackService, FeedbackService>();
			container.RegisterType<IUnitOfWork, UnitOfWork>(new InjectionConstructor("DefaultConnection"));

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}