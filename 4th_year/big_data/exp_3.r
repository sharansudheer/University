emp.data <- data.frame(
emp_id = c(1:7),
emp_fname= c ("Sharan", "Rishabh", "Manoj", "Rohini", "Chin", "Alex", "Joel"),
emp_lname= c ("Sudheer", "Nair", "Abraham", "Nair", "lal", "kuria", "Sam"),
doj = as.Date(c("2012-01-01", "2012-01-02", "2012-01-03", "2012-02-01", "2012-02-02","2012-01-06","2012-03-07")),
emp_add = c ("Kerala", "MP", "Chattisgharh", "Rajasthan", "Delhi", "MP", "Bangalore"),
emp_sex = c ("M","M","M","F","M","M","M"),
emp_sal = c (30000,15000,35000,50000,45000,48000,37000),
emp_dep = c ("HR","Management","Sales","Business","Finance","OpMgmt","Recruitment"),
stringsAsFactors = FALSE)

dept.data <-data.frame(
  dname=c("CSE","IT","MECH","CIVIL","EEE"),
  dno=c(1.0,2.0,3.0,4.0,5.0),
  noemp=c(120.0,130.0,110.0,150.0,160.0),
  stringsAsFactors = FALSE
)

str(emp.data)

str(dept.data)

print(summary(emp.data))
print(summary(dept.data))

r<-data.frame(emp.data$emp_fname,emp.data$emp_lname,emp.data$dep)
print(r)

gg<-data.frame(dept.data$dname,dept.data$noemp) 
print(gg)

we<-emp.data[1:3,]
print(we)

b<-dept.data[2:3,]
print(b)

emp.data$yoe<-c(3.0,4.0,2.0,6.0,1.0,3.0,6.0)

dept.data$postco<-c(515001.0,515440.0,515003.0,515009.0,545678.0)

str(emp.data)
str(dept.data)
