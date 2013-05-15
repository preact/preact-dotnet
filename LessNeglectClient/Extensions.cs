using System;
using System.Collections.Generic;

namespace LessNeglect
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

        #region MessageCreateRequest
        public static MessageCreateRequest ForPerson(this MessageCreateRequest req, Person person)
        {
            req.Person = person;
            return req;
        }

        public static MessageCreateRequest WithMessage(this MessageCreateRequest req, Message message)
        {
            req.Message = message;
            return req;
        }
        #endregion

        #region PersonUpdateRequest
        public static PersonUpdateRequest WithPerson(this PersonUpdateRequest req, Person person)
        {
            req.Person = person;
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

        public static ActionEvent WithLinks(this ActionEvent actionEvent, PersonActionLink[] links)
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

        public static Person WithExternalId(this Person person, string externalId)
        {
            person.ExternalId = externalId;
            return person;
        }

        public static Person WithAccountId(this Person person, string accountId)
        {
            person.AccountId = accountId;
            return person;
        }

        public static Person WithAccountName(this Person person, string accountName)
        {
            person.AccountName = accountName;
            return person;
        }

        public static Person WithCreationDateTime(this Person person, DateTime creationDateTime)
        {
            person.CreationDateTime = creationDateTime;
            return person;
        }

        public static Person WithProperties(this Person person, Dictionary<string, object> properties)
        {
            person.Properties = properties;
            return person;
        }
        #endregion

        #region PersonActionLink
        public static PersonActionLink WithHref(this PersonActionLink actionLink, string href)
        {
            actionLink.Href = href;
            return actionLink;
        }

        public static PersonActionLink WithName(this PersonActionLink actionLink, string name)
        {
            actionLink.Name = name;
            return actionLink;
        }
        #endregion

        #region Message
        public static Message WithSubject(this Message message, string subject)
        {
            message.Subject = subject;
            return message;
        }

        public static Message WithBody(this Message message, string body)
        {
            message.Body = body;
            return message;
        }

        public static Message WithLabel(this Message message, string label)
        {
            message.Label = label;
            return message;
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
