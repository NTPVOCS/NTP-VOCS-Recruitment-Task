# Animal shelter task

## Overview

Our shelter is responsible for taking care of brought animals.

This is so much work to do so we decided to give responsibility of feeding animals to external provider (`IAnimalFeedingService`).

Your task is to implement that service.

## Requirements

* Do not edit the following files:
  * `IAnimalFeedingService`
  * `IFeedable`
  * `AvailableFood`

## Definition of Done

Tests are passing (you need to add your implementation in test's class)

## Things to consider:

* Implementation of the service must be flexible so it can accept any type of animal and any amount of them (e.g. 2 horses, 3 capybaras and 1 seal or any future species e.g. dog)
* You have to know which type of food is acceptable by each animal (they're picky so they will be mad if you give them wrong type).
* After the job is done you could try to optimize the whole shelter (e.g. how animals are represented)