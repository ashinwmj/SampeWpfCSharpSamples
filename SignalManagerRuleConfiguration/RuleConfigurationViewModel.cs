using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;
using Prism.Commands;
using Prism.Mvvm;

namespace SignalManagerRuleConfiguration
{
    public class RuleConfigurationViewModel : BindableBase
    {

        private RuleConfiguration _editingRule;

        public RuleConfiguration EditingRule
        {
            get { return _editingRule; }
            private set { SetProperty(ref _editingRule, value); }
        }
        private RuleConfiguration _selectedRule;

        public RuleConfiguration SelectedRule
        {
            get { return _selectedRule; }
            set
            {
                if (SetProperty(ref _selectedRule, value))
                {
                    if (value == null)
                    {
                        EditingRule = new RuleConfiguration();
                        EditingRule.Conditions.Add(new RuleCondition());
                        EditingRule.Setters.Add(new RuleSetter());
                    }
                    else
                    {
                        EditingRule = value.Clone();
                    }
                }
            }
        }

        public static IList<string> DBFieldLists { get; } = new List<string>() { "SignalName", "SignalType", "IsAssign", "Xref" };

        public static IList<string> ConditionOperatorsList { get; } = new List<string>() { "And", "Or" };
        public IList<RuleConfiguration> Rules { get; set; } = new ObservableCollection<RuleConfiguration>();

        private static IList<string> _operators;

        public static IList<string> Operators
            =>
                _operators ??
                (_operators = HorizontalFieldConstants.OperatorMappingInfos.Select(x => x.EquivalentOperator).ToList());

        public RuleConfigurationViewModel()
        {
           // LoadXMlData();
            Reset();
        }

        private void LoadXMlData()
        {
            RuleSerialize rules = null;
            string path = @"c:\rule.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(RuleSerialize));

            StreamReader reader = new StreamReader(path);
            rules = (RuleSerialize)serializer.Deserialize(reader);
            reader.Close();
            foreach (var rule in rules.RuleConfigurations)
            {
                Rules.Add(rule);
            }
        }

        private void Reset()
        {
            SelectedRule = null;
            EditingRule = new RuleConfiguration();
            EditingRule.Conditions.Add(new RuleCondition());
            EditingRule.Setters.Add(new RuleSetter());
        }

        private DelegateCommand _addUpdateCommand;

        public DelegateCommand AddUpdateCommand
            => _addUpdateCommand ?? (_addUpdateCommand = new DelegateCommand(AddOrUpdate));

        private DelegateCommand<RuleCondition> _addConditionCommand;
        private DelegateCommand<RuleCondition> _removeConditionCommand;
        private DelegateCommand<RuleSetter> _addSetterCommand;
        private DelegateCommand<RuleSetter> _removeSetterCommand;
        private DelegateCommand _deleteRuleCommand;
        private DelegateCommand _addtoDBCommand;
        private DelegateCommand _importCommand;
        public DelegateCommand<RuleCondition> AddConditionCommand
       => _addConditionCommand ?? (_addConditionCommand = new DelegateCommand<RuleCondition>(AddCondition));

        private void AddCondition(RuleCondition condition)
        {
            var index = EditingRule.Conditions.IndexOf(condition);
            EditingRule.Conditions.Insert(index + 1, new RuleCondition());
        }
        public DelegateCommand<RuleCondition> RemoveConditionCommand
            =>
                _removeConditionCommand ?? (_removeConditionCommand = new DelegateCommand<RuleCondition>(RemoveCondition));

        private void RemoveCondition(RuleCondition condition)
        {
            var index = EditingRule.Conditions.IndexOf(condition);
            if (EditingRule.Conditions.Count > 1)
            {
                EditingRule.Conditions.RemoveAt(index);
            }
        }

        public DelegateCommand<RuleSetter> AddSetterCommand
            => _addSetterCommand ?? (_addSetterCommand = new DelegateCommand<RuleSetter>(AddSetter));

        private void AddSetter(RuleSetter setter)
        {
            var index = EditingRule.Setters.IndexOf(setter);
            EditingRule.Setters.Insert(index + 1, new RuleSetter());
        }

        public DelegateCommand<RuleSetter> RemoveSetterCommand
            => _removeSetterCommand ?? (_removeSetterCommand = new DelegateCommand<RuleSetter>(RemoveSetter));

        private void RemoveSetter(RuleSetter setter)
        {
            var index = EditingRule.Setters.IndexOf(setter);
            if (EditingRule.Setters.Count > 1)
            {
                EditingRule.Setters.RemoveAt(index);
            }

        }

        public DelegateCommand DeleteRuleCommand
            => _deleteRuleCommand ?? (_deleteRuleCommand = new DelegateCommand(DeleteRule));

        private void DeleteRule()
        {
            var index = Rules.IndexOf(SelectedRule);
            Rules.RemoveAt(index);
            AddOrUpdateDB();
        }

        private void AddOrUpdate()
        {
            if (SelectedRule == null)
            {
                var ruleName = Rules.FirstOrDefault(x => x.Name == EditingRule.Name);

                if (ruleName == null)
                {
                    Rules.Add(EditingRule);
                    AddOrUpdateDB();
                }
                else
                {
                    MessageBox.Show("Rule name already exists");
                }

            }
            else
            {
                var index = Rules.IndexOf(SelectedRule);
                Rules[index] = EditingRule;
            }
            Reset();

           
        }

        //public DelegateCommand AddtoDBCommand
        //    => _addtoDBCommand ?? (_addtoDBCommand = new DelegateCommand(AddtoDB));

        private void AddOrUpdateDB()
        {
            RuleSerialize ruleSerialize = new RuleSerialize() { RuleConfigurations = Rules.ToArray() };

            var xmlSerializer = new XmlSerializer(typeof(RuleSerialize));

            TextWriter txtWriter = new StreamWriter(@"c:\rule.xml");

            xmlSerializer.Serialize(txtWriter, ruleSerialize);

            txtWriter.Close();



        }
        public DelegateCommand ImportCommand
            => _importCommand ?? (_importCommand = new DelegateCommand(Import));

        private void Import()
        {


        }
    }
}
