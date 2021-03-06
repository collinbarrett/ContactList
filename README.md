# Contact List
A simple practice MVC application built on .NET Core.

## Summary
Develop an MVC/C# application; this application should only meet the below use case.

 - Primary actors: Any user
 - Preconditions:  Web site is running

## Basic flows of events:
 1. User browses to web page
 2. Application displays list of 10 contacts
 3. User selects contact
 4. Application displays contact details including:
    - Name (first and last)
    - Email Addresses 
    - Phone numbers (Business, Home, Mobile, etc.)
    - Address (one)
    - Notes
 5. User selects “close”
 6. Application displays/enables the same list of contacts that was viewed before they selected a contact

## Alternate flows:
 3. This alternate flow begins after step 2
    - User can browse to the next/previous ten contacts

## Other info:
 - Initial contact list should have at least 25 fictional contacts 
 - Initial contact list should load from an XML file
 - User should NOT be able to modify contacts