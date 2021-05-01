/*ALTER TABLE Tour
ADD CONSTRAINT FK_TF FOREIGN KEY (Food) REFERENCES Food(FoodID),
ADD CONSTRAINT FK_TH FOREIGN KEY (Hotel) REFERENCES Hotel(HotelID),
ADD CONSTRAINT FK_TT FOREIGN KEY (Transfer) REFERENCES Transfer(TransferID);
*/

ALTER TABLE Booking 
ADD CONSTRAINT UK_L UNIQUE (Login),
ADD CONSTRAINT FK_BU FOREIGN KEY (Customer) REFERENCES Users(UserID);

/*ALTER TABLE City ADD
CONSTRAINT UK_C UNIQUE (Name);

ALTER TABLE Hotel 
ADD CONSTRAINT UK_H UNIQUE (Name),
ADD CONSTRAINT FK_HC FOREIGN KEY (City) REFERENCES City(CityID);

/*CHECK*/
ALTER TABLE Food 
ADD CONSTRAINT FCost_chk CHECK (Cost >= 0);

ALTER TABLE Tour 
ADD CONSTRAINT TCost_chk CHECK (Cost >= 0),
ADD CONSTRAINT TDate_chk CHECK (DateBegin <= DateEnd);

ALTER TABLE Hotel 
ADD CONSTRAINT HCost_chk CHECK (Cost >= 0),
ADD CONSTRAINT Type_chk CHECK (Type = 'Hostel' OR Type = 'Mini' OR 
				Type = 'Resort' OR Type = 'Guest house' OR 
				Type = 'Apart' OR Type = 'B&B' OR 
				Type = 'Business' OR Type = 'Motel' OR Type = 'Spa'),
ADD CONSTRAINT Class_chk CHECK (Class >= 0 AND Class <= 5);
*/