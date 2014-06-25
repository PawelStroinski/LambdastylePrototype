using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Test
{
    class DemoExporter
    {
        JArray demo, styles;
        string inputName;

        [Ignore("Run manually")]
        [TestCase(@"T:\DemoExporter.json")]
        public void Export(string destination)
        {
            demo = new JArray();
            BuildInput1();
            BuildInput2();
            BuildInput3();
            BuildInput4();
            BuildInput5();
            var exported = demo.ToString();
            File.WriteAllText(destination, exported);
        }

        void BuildInput1()
        {
            Add<Test.input1.json._1_singlerun_true.Style>("set singleRun to true");
            Add<Test.input1.json._1_1_remove_commonjs_from_all_arrays.Style>();
            Add<Test.input1.json._1_1_replace_commonjs_with_amd_only_in_frameworks.Style>();
            Add<Test.input1.json._1_1_remove_every_array_containing_commonjs.Style>();
            Add<Test.input1.json._1_1_add_key_at_the_end_of_file.Style>();
            Add<Test.input1.json._1_1_output_plugins_with_key.Style>();
            Add<Test.input1.json._1_1_output_plugins_without_key.Style>();
            Add<Test.input1.json._1_1_output_plugins_separated_by_comma.Style>();
            Add<Test.input1.json._1_1_output_reporters_and_plugins_as_two_lists.Style>();
            Add<Test.input1.json._1_1_reportes_and_plugins_under_common_key.Style>();
            Add<Test.input1.json._1_1_custom_key_and_colors_key.Style>();
            Add<Test.input1.json._1_1_add_custom_to_reporters.Style>();
            Add<Test.input1.json._1_1_add_custom_to_reporters_and_output_only_array.Style>();
            Add<Test.input1.json._1_1_only_keys_with_value_500.Style>();
            Add<Test.input1.json._1_1_pack_elements_in_arrays.Style>("pack elements in arrays ([1,2]->[[1],[2]])");
            Add<Test.input1.json._1_2_config.Style>("config (export to XML)");
        }

        void BuildInput2()
        {
            Add<Test.input2.json._2_remove_the_Close_menu_item.Style>();
            Add<Test.input2.json._2_change_id_to_file2.Style>();
            Add<Test.input2.json._2_replace_Open_menu_item_with_Export.Style>();
            Add<Test.input2.json._2_rename_menuitem_to_menuitems.Style>();
            Add<Test.input2.json._2_add_Export_menu_item.Style>();
            Add<Test.input2.json._2_move_popup_into_popupParent.Style>();
            Add<Test.input2.json._2_move_popup_as_menu_sibling.Style>();
            Add<Test.input2.json._2_rename_value_in_menu_only.Style>();
            Add<Test.input2.json._2_rename_value_in_menuitem_item_only.Style>();
        }

        void BuildInput3()
        {
            Add<Test.input3.json._3_swap_offsets_in_text.Style>("swap offsets in \"text\"");
            Add<Test.input3.json._3_copy_image_as_image2.Style>("copy \"image\" as \"image2\"");
            Add<Test.input3.json._3_copy_image_as_a_widget_sibling.Style>("copy \"image\" as a \"widget\" sibling");
            Add<Test.input3.json._3_replace_name_sun1_with_sun2.Style>("replace name \"sun1\" with \"sun2\"");
            Add<Test.input3.json._3_convert_widget_to_an_array.Style>();
            Add<Test.input3.json._3_remove_each_dictionary_with_alignment.Style>(
                "remove each dictionary with \"alignment\"");
            Add<Test.input3.json._3_output_copy_only_if_debug_on.Style>("output copy only if debug=on");
            Add<Test.input3.json._3_copy_title_from_window_to_image.Style>();
            Add<Test.input3.json._3_if_name_is_text1_set_parent_alignment_to_left.Style>();
            Add<Test.input3.json._3_if_name_is_text1_set_parent_alignment_to_right_else_to_left.Style>();
        }

        void BuildInput4()
        {
            Add<Test.input4.json._4_change_first_servlet_class.Style>("change first servlet's class");
            Add<Test.input4.json._4_swap_first_and_second_servlet.Style>();
            Add<Test.input4.json._4_copy_params_from_cofaxEmail_to_cofaxTools.Style>();
            Add<Test.input4.json._4_remove_every_key_with_value_ending_with_id.Style>(
                "remove every key with value ending with &id=");
        }

        void BuildInput5()
        {
            Add<Test.input5.json._5_replace_every_null_with_curly_braces.Style>("replace every null with {}");
            Add<Test.input5.json._5_if_id_is_present_but_not_label_copy_it_as_label.Style>(
                "if id is present but not label, copy it as label");
            Add<Test.input5.json._5_append_dots_to_every_label_not_ending_with_dots.Style>(
                "append ... to every label not ending with ...");
            Add<Test.input5.json._5_convert_back_to_XML.Style>(
                "convert back to XML (http://json.org/example.html - last one)");
            Add<Test.input5.json._5_render_as_ASCII_context_menu.Style>();
            Add<Test.input5.json._5_convert_items_to_dictionary_by_id.Style>();
            Add<Test.input5.json._5_remove_keys_with_values_containing_two_upper_letters.Style>();
            Add<Test.input5.json._5_move_Mute_item_before_About_item.Style>();
            Add<Test.input5.json._5_copy_every_label_as_description.Style>();
            Add<Test.input5.json._5_replace_space_with_pipe_in_two_word_labels.Style>(
                "replace space with pipe in two-word labels");
        }

        void Add<TStyle>()
        {
            var folders = RunnerUtils.NamespaceFolders(typeof(TStyle).Namespace);
            var groups = Regex.Match(folders.Item2, "[^ ]+ (.+)").Groups;
            var comment = groups[1].Value;
            Add<TStyle>(comment);
        }

        void Add<TStyle>(string styleName)
        {
            var folders = RunnerUtils.NamespaceFolders(typeof(TStyle).Namespace);
            if (folders.Item1 != inputName)
                StartInput(folders);
            var style = new JObject();
            styles.Add(style);
            style["styleName"] = styleName;
            var styleFile = RunnerUtils.StyleFileFullPath(folders);
            var styleBody = File.ReadAllText(styleFile);
            style["styleBody"] = styleBody;
        }

        void StartInput(Tuple<string, string> folders)
        {
            inputName = folders.Item1;
            var input = new JObject();
            demo.Add(input);
            input["inputName"] = folders.Item1;
            var inputFile = RunnerUtils.InputFileFullPath(folders);
            var inputBody = File.ReadAllText(inputFile);
            input["inputBody"] = inputBody;
            styles = new JArray();
            input["styles"] = styles;
        }
    }
}
