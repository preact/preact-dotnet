/*
 * Copyright 2014 Preact / Preact.io
 *
 * Author(s):
 *  Christopher Gooley / Preact (gooley@preact.io)
 *  Billy Coover / Preact (gooley@preact.io)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;

namespace Preact
{
    public static class Extensions
    {
        #region ActionEventCreateRequest
        public static ActionEventCreateRequest ForPerson(this ActionEventCreateRequest req, Person person)
        {
            req.Person = person;
            return req;
        }

        public static ActionEventCreateRequest WithEvent(this ActionEventCreateRequest req, ActionEvent actionEvent)
        {
            req.Event = actionEvent;
            return req;
        }
        #endregion

        #region ActionEvent
        public static ActionEvent WithName(this ActionEvent actionEvent, string name)
        {
            actionEvent.Name = name;
            return actionEvent;
        }

        public static ActionEvent WithNote(this ActionEvent actionEvent, string note)
        {
            actionEvent.Note = note;
            return actionEvent;
        }

        public static ActionEvent WithLinks(this ActionEvent actionEvent, ActionLink[] links)
        {
            actionEvent.Links = links;
            return actionEvent;
        }

        public static ActionEvent WithAccount(this ActionEvent actionEvent, Account account)
        {
            actionEvent.Account = account;
            return actionEvent;
        }

        public static ActionEvent WithRevenue(this ActionEvent actionEvent, decimal revenue)
        {
            actionEvent.Revenue = revenue;
            return actionEvent;
        }

        public static ActionEvent WithExtras(this ActionEvent actionEvent, Dictionary<string, object> extras)
        {
            actionEvent.Extras = extras;
            return actionEvent;
        }
        #endregion

        #region Person
        public static Person WithEmail(this Person person, string email)
        {
            person.Email = email;
            return person;
        }

        public static Person WithName(this Person person, string name)
        {
            person.Name = name;
            return person;
        }

        public static Person WithUid(this Person person, string uid)
        {
            person.Uid = uid;
            return person;
        }

        public static Person WithTwitterId(this Person person, string twitterId)
        {
            person.TwitterId = twitterId;
            return person;
        }

        public static Person WithFacebookId(this Person person, string facebookId)
        {
            person.FacebookId = facebookId;
            return person;
        }

        public static Person WithStripeId(this Person person, string stripeId)
        {
            person.StripeId = stripeId;
            return person;
        }

        public static Person WithCreatedAt(this Person person, DateTime createdAt)
        {
            person.CreatedAt = createdAt;
            return person;
        }

        public static Person WithProperties(this Person person, Dictionary<string, object> properties)
        {
            person.Properties = properties;
            return person;
        }
        #endregion

        #region PersonActionLink
        public static ActionLink WithHref(this ActionLink actionLink, string href)
        {
            actionLink.Href = href;
            return actionLink;
        }

        public static ActionLink WithName(this ActionLink actionLink, string name)
        {
            actionLink.Name = name;
            return actionLink;
        }
        #endregion

        #region Account
        public static Account WithId(this Account account, string id)
        {
            account.Id = id;
            return account;
        }

        public static Account WithName(this Account account, string name)
        {
            account.Name = name;
            return account;
        }
        #endregion
    }
}
