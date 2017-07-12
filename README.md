# ContactList
A simple practice MVC application.

## Summary
Develop a MVC/C# application; this application should only meet the attached use case.

 - Primary actors: Any user
 - Preconditions:  Web site is running

## Basic flows of events:
 1. User browses to web page
 2. Application displays list of 10 contacts
 3. User selects contact
 4. Application displays contact details
    Details include:
    a. Name (first and last)
    b. Email Addresses 
    c. Phone numbers (Business, Home, Mobile, etc.)
    d. Address (one)
    e. Notes
 5. User selects “close”
 6. Application displays/enables same list of contacts use was view when they selected a contact

## Alternate flows:
 3. This alternate flow begins after step 2
    a. User can browse to the next/previous 10 contacts

## Other info
 - Initial contact list should have at least 25 fictional contacts 
 - Initial contact list should load from a XML file
 - User should NOT be able modify contacts