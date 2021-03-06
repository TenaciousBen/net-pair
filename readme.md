# Preamble

Your company has recently acquired a new hotel. Unfortunately the previous administration badly misunderstood the requirements of GDPR and thought that it was now illegal to divulge prices to customers. As a result, you've been tasked with coming up with a price calculator that tells customers what the best available price is for their stay, taking into account any special offers that are applicable for the duration.

You're going to make it as a console app, because customers just fricking love console apps.

# Structure

The solution is structured into 3 basic projects:

* A console application
* A class library
* A test project

The class library has a `StayCalculator` which calculates the cheapest stay for a given trip using the data provided by the `HotelRoomRateRepository` and `SpecialOfferRepository`. The console application part of the solution is already finished, so you can just focus on the class library and test project.

# Outcome

Once completed, the console application should be able to correctly calculate stays. Please ensure that you add whatever testing you're comfortable with, and feel free to ask questions along the way.