using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;

namespace Zisa_Database_course_session
{
    public class VM : INotifyPropertyChanged
    {
        DB db = DB.GetInstance();

        #region Property
        private BindingList<Session> sessions;
        public BindingList<Session> Sessions
        {
            get { return sessions; }
            set { sessions = value; NotifyChanged(); }
        }

        private BindingList<CourseOffering> courseOfferings;
        public BindingList<CourseOffering> CourseOfferings
        {
            get { return courseOfferings; }
            set { courseOfferings = value; NotifyChanged(); }
        }

        private Session selectedSession;
        public Session SelectedSession
        {
            get { return selectedSession; }
            set { selectedSession = value; NotifyChanged(); }
        }

        private CourseOffering selectedCourseOffering;
        public CourseOffering SelectedCourseOffering
        {
            get { return selectedCourseOffering; }
            set { selectedCourseOffering = value; NotifyChanged(); }
        }

        private Course courseDetail;
        public Course CourseDetail
        {
            get { return courseDetail; }
            set { courseDetail = value; NotifyChanged(); }
        }

        private BindingList<Course> courses;
        public BindingList<Course> Courses
        {
            get { return courses; }
            set { courses = value; NotifyChanged(); }
        }

        private Course detailWindowSelectedCourse;
        public Course DetailWindowSelectedCourse
        {
            get { return detailWindowSelectedCourse; }
            set { detailWindowSelectedCourse = value; NotifyChanged(); }
        }

        private Session detailWindowSelectedSession;
        public Session DetailWindowSelectedSession
        {
            get { return detailWindowSelectedSession; }
            set { detailWindowSelectedSession = value; NotifyChanged(); }
        }
        #endregion

        #region Logic

        //method to get course detail for a selected Session code--Combobox to ListBox
        public void GetCourseOffering()
        {

            CourseOfferings = new BindingList<CourseOffering>(db.GetCourseOffering(SelectedSession));
        }

        //method to get Course detal for a selected course--2nd List to dw 
        public void GetSelectedCourseOffering()
        {
            CourseDetail = db.GetSelectedCourseOffering(SelectedCourseOffering);
        }

        //Methid to get couese list in dw2
        public void GetCourseList()
        {
            Courses = new BindingList<Course>(db.GetCourse());
        }

        public void SaveNewCourseSession()
        {
            db.SaveNewCourseSession(DetailWindowSelectedSession, DetailWindowSelectedCourse);
        }

        public VM()
        {
            sessions = new BindingList<Session>(db.GetSession());

        }
        #endregion

        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion
    }
}
