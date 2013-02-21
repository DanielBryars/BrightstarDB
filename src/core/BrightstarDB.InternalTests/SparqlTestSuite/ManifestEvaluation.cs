using System.Collections.Generic;
using System.IO;
using BrightstarDB.Rdf;
using BrightstarDB.Storage;
using BrightstarDB.Storage.BTreeStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using System.Linq;

namespace BrightstarDB.Tests.SparqlTestSuite {
    [TestClass]
	public partial class ManifestEvaluation {

		private IStoreManager _storeManager;
        private string _storeLocation;
        private IStore _store;

        public ManifestEvaluation()
        {
            _storeManager = StoreManagerFactory.GetStoreManager();
        }

		[TestInitialize]
		public void SetUp()
		{
		    _storeLocation = "brightstar\\" + Guid.NewGuid();
		    _store = _storeManager.CreateStore(_storeLocation);
		}

        [TestCleanup]
        public void TearDown()
        {
            _store.Dispose();
            _storeManager.DeleteStore(_storeLocation);
        }

		#region Test Methods

		[TestMethod]
		public void NonMatchingTriplePattern() {
	
					ImportData(@"data-r2/basic/data-7.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/bgp-no-match.rq");
			CheckResult(result, @"data-r2/basic/bgp-no-match.srx", false);

	
		}

		[TestMethod]
		public void PrefixName1() {
	
					ImportData(@"data-r2/basic/data-6.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/prefix-name-1.rq");
			CheckResult(result, @"data-r2/basic/prefix-name-1.srx", false);

	
		}

		[TestMethod]
		public void BasicGraphPatternSpoo() {
	
					ImportData(@"data-r2/basic/data-6.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/spoo-1.rq");
			CheckResult(result, @"data-r2/basic/spoo-1.srx", false);

	
		}

		[TestMethod]
		public void BasicPrefixBase1() {
	
					ImportData(@"data-r2/basic/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/base-prefix-1.rq");
			CheckResult(result, @"data-r2/basic/base-prefix-1.srx", false);

	
		}

		[TestMethod]
		public void BasicPrefixBase2() {
	
					ImportData(@"data-r2/basic/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/base-prefix-2.rq");
			CheckResult(result, @"data-r2/basic/base-prefix-2.srx", false);

	
		}

		[TestMethod]
		public void BasicPrefixBase3() {
	
					ImportData(@"data-r2/basic/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/base-prefix-3.rq");
			CheckResult(result, @"data-r2/basic/base-prefix-3.srx", false);

	
		}

		[TestMethod]
		public void BasicPrefixBase4() {
	
					ImportData(@"data-r2/basic/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/base-prefix-4.rq");
			CheckResult(result, @"data-r2/basic/base-prefix-4.srx", false);

	
		}

		[TestMethod]
		public void BasicPrefixBase5() {
	
					ImportData(@"data-r2/basic/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/base-prefix-5.rq");
			CheckResult(result, @"data-r2/basic/base-prefix-5.srx", false);

	
		}

		[TestMethod]
		public void BasicList1() {
	
					ImportData(@"data-r2/basic/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/list-1.rq");
			CheckResult(result, @"data-r2/basic/list-1.srx", false);

	
		}

		[TestMethod]
		public void BasicList2() {
	
					ImportData(@"data-r2/basic/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/list-2.rq");
			CheckResult(result, @"data-r2/basic/list-2.srx", false);

	
		}

		[TestMethod]
		public void BasicList3() {
	
					ImportData(@"data-r2/basic/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/list-3.rq");
			CheckResult(result, @"data-r2/basic/list-3.srx", false);

	
		}

		[TestMethod]
		public void BasicList4() {
	
					ImportData(@"data-r2/basic/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/list-4.rq");
			CheckResult(result, @"data-r2/basic/list-4.srx", false);

	
		}

		[TestMethod]
		public void BasicQuotes1() {
	
					ImportData(@"data-r2/basic/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/quotes-1.rq");
			CheckResult(result, @"data-r2/basic/quotes-1.srx", false);

	
		}

		[TestMethod]
		public void BasicQuotes2() {
	
					ImportData(@"data-r2/basic/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/quotes-2.rq");
			CheckResult(result, @"data-r2/basic/quotes-2.srx", false);

	
		}

		[TestMethod]
		public void BasicQuotes3() {
	
					ImportData(@"data-r2/basic/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/quotes-3.rq");
			CheckResult(result, @"data-r2/basic/quotes-3.srx", false);

	
		}

		[TestMethod]
		public void BasicQuotes4() {
	
					ImportData(@"data-r2/basic/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/quotes-4.rq");
			CheckResult(result, @"data-r2/basic/quotes-4.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm1() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-1.rq");
			CheckResult(result, @"data-r2/basic/term-1.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm2() {
	
					ImportData(@"data-r2/basic/data-4.ttl");

		
			var result = ExecuteQuery(@"data-r2/basic/term-2.rq");
			CheckResult(result, @"data-r2/basic/term-2.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm3() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-3.rq");
			CheckResult(result, @"data-r2/basic/term-3.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm4() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-4.rq");
			CheckResult(result, @"data-r2/basic/term-4.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm5() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-5.rq");
			CheckResult(result, @"data-r2/basic/term-5.srx", false);

	
		}

		[TestMethod]
        [Ignore]
		public void BasicTerm6() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-6.rq");
			CheckResult(result, @"data-r2/basic/term-6.srx", false);

	
		}

		[TestMethod]
        [Ignore]
		public void BasicTerm7() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-7.rq");
			CheckResult(result, @"data-r2/basic/term-7.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm8() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-8.rq");
			CheckResult(result, @"data-r2/basic/term-8.srx", false);

	
		}

		[TestMethod]
		public void BasicTerm9() {
	
					ImportData(@"data-r2/basic/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/term-9.rq");
			CheckResult(result, @"data-r2/basic/term-9.srx", false);

	
		}

		[TestMethod]
		public void BasicVar1() {
	
					ImportData(@"data-r2/basic/data-5.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/var-1.rq");
			CheckResult(result, @"data-r2/basic/var-1.srx", false);

	
		}

		[TestMethod]
		public void BasicVar2() {
	
					ImportData(@"data-r2/basic/data-5.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/basic/var-2.rq");
			CheckResult(result, @"data-r2/basic/var-2.srx", false);

	
		}

		[TestMethod]
		public void DawgTriplePattern001() {
	
					ImportData(@"data-r2/triple-match/data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/triple-match/dawg-tp-01.rq");
			CheckResult(result, @"data-r2/triple-match/result-tp-01.ttl", false);

	
		}

		[TestMethod]
		public void DawgTriplePattern002() {
	
					ImportData(@"data-r2/triple-match/data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/triple-match/dawg-tp-02.rq");
			CheckResult(result, @"data-r2/triple-match/result-tp-02.ttl", false);

	
		}

		[TestMethod]
		public void DawgTriplePattern003() {
	
					ImportData(@"data-r2/triple-match/data-02.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/triple-match/dawg-tp-03.rq");
			CheckResult(result, @"data-r2/triple-match/result-tp-03.ttl", false);

	
		}

		[TestMethod]
		public void DawgTriplePattern004() {
	
					ImportData(@"data-r2/triple-match/dawg-data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/triple-match/dawg-tp-04.rq");
			CheckResult(result, @"data-r2/triple-match/result-tp-04.ttl", false);

	
		}

		[TestMethod]
		public void OpenEq01() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-01.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-01-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq02() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-02.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-02-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq03() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-03.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-03-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq04() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-04.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-04-result.srx", false);

	
		}

		[TestMethod, Ignore, Description("VariableEqualsOptimiser removes the static variable value from the results set")]
		public void OpenEq05() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-05.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-05-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq06() {
	
					ImportData(@"data-r2/open-world/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-06.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-06-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq07() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-07.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-07-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq08() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-08.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-08-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq09() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-09.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-09-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq10() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-10.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-10-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq11() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-11.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-11-result.srx", false);

	
		}

		[TestMethod]
		public void OpenEq12() {
	
					ImportData(@"data-r2/open-world/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-eq-12.rq");
			CheckResult(result, @"data-r2/open-world/open-eq-12-result.srx", false);

	
		}

		[TestMethod]
		public void Date1() {
	
					ImportData(@"data-r2/open-world/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/date-1.rq");
			CheckResult(result, @"data-r2/open-world/date-1-result.srx", false);

	
		}

		[TestMethod]
		public void Date2() {
	
					ImportData(@"data-r2/open-world/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/date-2.rq");
			CheckResult(result, @"data-r2/open-world/date-2-result.srx", false);

	
		}

        /* NOTE: B* currently fails this test because we internally store date and dateTime
         * resources as the same datatype so they end up comparing where the query does not
         * expect it. This also affects OpenCmp01 and OpenCmp02 tests.
         */
		[TestMethod]
		public void Date3() {
	
					ImportData(@"data-r2/open-world/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/date-3.rq");
			CheckResult(result, @"data-r2/open-world/date-3-result.srx", false);

	
		}

		[TestMethod]
		public void Date4() {
	
					ImportData(@"data-r2/open-world/data-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/date-4.rq");
			CheckResult(result, @"data-r2/open-world/date-4-result.srx", false);

	
		}

        /* NOTE: B* currently generates incorrect results for this test because
         dateTime and date schema types are both stored as a DateTime internally
         so we end up doing a compare where the test expects none to be attempted.
        */
		[TestMethod]
		public void OpenCmp01() {
	
					ImportData(@"data-r2/open-world/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-cmp-01.rq");
			CheckResult(result, @"data-r2/open-world/open-cmp-01-result.srx", false);

	
		}

        /* NOTE: B* currently fails this test for the same reason that it fails OpenCmp01 */
		[TestMethod]
		public void OpenCmp02() {
	
					ImportData(@"data-r2/open-world/data-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/open-world/open-cmp-02.rq");
			CheckResult(result, @"data-r2/open-world/open-cmp-02-result.srx", false);

	
		}

		[TestMethod]
		public void JoinOperatorWithOptsBgpsAndUnions() {
	
					ImportData(@"data-r2/algebra/join-combo-graph-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/join-combo-1.rq");
			CheckResult(result, @"data-r2/algebra/join-combo-1.srx", false);

	
		}

		[TestMethod]
		public void JoinOperatorWithGraphAndUnion() {
	
					ImportData(@"data-r2/algebra/join-combo-graph-2.ttl");
		
					ImportGraph("data-r2/algebra/join-combo-graph-1.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/algebra/join-combo-graph-1.ttl"));
		
			var result = ExecuteQuery(@"data-r2/algebra/join-combo-2.rq");
			CheckResult(result, @"data-r2/algebra/join-combo-2.srx", false);

	
		}

		[TestMethod]
		public void NestedOptionals1() {
	
					ImportData(@"data-r2/algebra/two-nested-opt.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/two-nested-opt.rq");
			CheckResult(result, @"data-r2/algebra/two-nested-opt.srx", false);

	
		}

		[TestMethod]
		public void NestedOptionals2() {
	
					ImportData(@"data-r2/algebra/two-nested-opt.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/two-nested-opt-alt.rq");
			CheckResult(result, @"data-r2/algebra/two-nested-opt-alt.srx", false);

	
		}

		[TestMethod]
		public void OptionalFilter1() {
	
					ImportData(@"data-r2/algebra/opt-filter-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/opt-filter-1.rq");
			CheckResult(result, @"data-r2/algebra/opt-filter-1.srx", false);

	
		}

		[TestMethod]
		public void OptionalFilter2Filters() {
	
					ImportData(@"data-r2/algebra/opt-filter-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/opt-filter-2.rq");
			CheckResult(result, @"data-r2/algebra/opt-filter-2.srx", false);

	
		}

		[TestMethod]
		public void OptionalFilterScopeOfVariable() {
	
					ImportData(@"data-r2/algebra/opt-filter-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/opt-filter-3.rq");
			CheckResult(result, @"data-r2/algebra/opt-filter-3.srx", false);

	
		}

		[TestMethod]
		public void FilterPlacement1() {
	
					ImportData(@"data-r2/algebra/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-placement-1.rq");
			CheckResult(result, @"data-r2/algebra/filter-placement-1.srx", false);

	
		}

		[TestMethod]
		public void FilterPlacement2() {
	
					ImportData(@"data-r2/algebra/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-placement-2.rq");
			CheckResult(result, @"data-r2/algebra/filter-placement-2.srx", false);

	
		}

		[TestMethod]
		public void FilterPlacement3() {
	
					ImportData(@"data-r2/algebra/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-placement-3.rq");
			CheckResult(result, @"data-r2/algebra/filter-placement-3.srx", false);

	
		}

		[TestMethod]
		public void FilterNested1() {
	
					ImportData(@"data-r2/algebra/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-nested-1.rq");
			CheckResult(result, @"data-r2/algebra/filter-nested-1.srx", false);

	
		}

		[TestMethod]
		public void FilterNested2() {
	
					ImportData(@"data-r2/algebra/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-nested-2.rq");
			CheckResult(result, @"data-r2/algebra/filter-nested-2.srx", false);

	
		}

		[TestMethod]
		public void FilterScope1() {
	
					ImportData(@"data-r2/algebra/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/filter-scope-1.rq");
			CheckResult(result, @"data-r2/algebra/filter-scope-1.srx", false);

	
		}

		[TestMethod]
		public void JoinScope1() {
	
					ImportData(@"data-r2/algebra/var-scope-join-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/algebra/var-scope-join-1.rq");
			CheckResult(result, @"data-r2/algebra/var-scope-join-1.srx", false);

	
		}

		[TestMethod]
		public void DawgBnodeCoreference() {
	
					ImportData(@"data-r2/bnode-coreference/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/bnode-coreference/query.rq");
			CheckResult(result, @"data-r2/bnode-coreference/result.ttl", false);

	
		}

		[TestMethod]
		public void ComplexOptionalSemantics1() {
	
					ImportData(@"data-r2/optional/complex-data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-complex-1.rq");
			CheckResult(result, @"data-r2/optional/result-opt-complex-1.ttl", false);

	
		}

		[TestMethod]
		public void ComplexOptionalSemantics2() {
	
					ImportData(@"data-r2/optional/complex-data-2.ttl");
		
					ImportGraph("data-r2/optional/complex-data-1.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/optional/complex-data-1.ttl"));
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-complex-2.rq");
			CheckResult(result, @"data-r2/optional/result-opt-complex-2.ttl", false);

	
		}

		[TestMethod]
		public void ComplexOptionalSemantics3() {
	
					ImportData(@"data-r2/optional/complex-data-2.ttl");
		
					ImportGraph("data-r2/optional/complex-data-1.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/optional/complex-data-1.ttl"));
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-complex-3.rq");
			CheckResult(result, @"data-r2/optional/result-opt-complex-3.ttl", false);

	
		}

		[TestMethod]
		public void ComplexOptionalSemantics4() {
	
					ImportData(@"data-r2/optional/complex-data-2.ttl");
		
					ImportGraph("data-r2/optional/complex-data-1.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/optional/complex-data-1.ttl"));
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-complex-4.rq");
			CheckResult(result, @"data-r2/optional/result-opt-complex-4.ttl", false);

	
		}

		[TestMethod]
		public void OneOptionalClause() {
	
					ImportData(@"data-r2/optional/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-1.rq");
			CheckResult(result, @"data-r2/optional/result-opt-1.ttl", false);

	
		}

		[TestMethod]
		public void TwoOptionalClauses() {
	
					ImportData(@"data-r2/optional/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-2.rq");
			CheckResult(result, @"data-r2/optional/result-opt-2.ttl", false);

	
		}

		[TestMethod]
		public void UnionIsNotOptional() {
	
					ImportData(@"data-r2/optional/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional/q-opt-3.rq");
			CheckResult(result, @"data-r2/optional/result-opt-3.ttl", false);

	
		}

		[TestMethod]
		public void OptionalFilter() {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-1.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-1-result.ttl", false);

	
		}

		[TestMethod]
		public void OptionalOuterFilter() {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-2.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-2-result.ttl", false);

	
		}

		[TestMethod]
		public void OptionalOuterFilterWithBound() {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-3.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-3-result.ttl", false);

	
		}

		[TestMethod]
		public void OptionalInnerFilterWithNegativeEbvForOuterVariables() {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-4.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-4-result.ttl", false);

	
		}

        [TestMethod]
        public void DawgOptionalFilter005Simplified()
        {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-5.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-5-result-simplified.ttl", false);

	
		}

        [Description("Note: dotNetRDF passes the DawgOptionalFilter005Simplified Test"), TestMethod]
        public void DawgOptionalFilter005NotSimplified()
        {
	
					ImportData(@"data-r2/optional-filter/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/optional-filter/expr-5.rq");
			CheckResult(result, @"data-r2/optional-filter/expr-5-result-not-simplified.ttl", false);

	
		}

		[TestMethod]
		public void Graph01() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/graph/graph-01.rq");
			CheckResult(result, @"data-r2/graph/graph-01.ttl", false);

	
		}

		[TestMethod]
		public void Graph04() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/graph/graph-04.rq");
			CheckResult(result, @"data-r2/graph/graph-04.ttl", false);

	
		}

		[TestMethod]
		public void Graph05() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
					ImportGraph("data-r2/graph/data-g2.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g2.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-05.rq");
			CheckResult(result, @"data-r2/graph/graph-05.ttl", false);

	
		}

		[TestMethod]
		public void Graph06() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
					ImportGraph("data-r2/graph/data-g2.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g2.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-06.rq");
			CheckResult(result, @"data-r2/graph/graph-06.ttl", false);

	
		}

		[TestMethod]
		public void Graph07() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
					ImportGraph("data-r2/graph/data-g2.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g2.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-07.rq");
			CheckResult(result, @"data-r2/graph/graph-07.ttl", false);

	
		}

		[TestMethod]
		public void Graph08() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
					ImportGraph("data-r2/graph/data-g2.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g2.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-08.rq");
			CheckResult(result, @"data-r2/graph/graph-08.ttl", false);

	
		}

		[TestMethod]
		public void Graph09() {
	
					ImportData(@"data-r2/graph/data-g3.ttl");
		
					ImportGraph("data-r2/graph/data-g4.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g4.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-09.rq");
			CheckResult(result, @"data-r2/graph/graph-09.ttl", false);

	
		}

		[TestMethod]
		public void Graph10() {
	
					ImportData(@"data-r2/graph/data-g3.ttl");
		
					ImportGraph("data-r2/graph/data-g3.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g3.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-10.rq");
			CheckResult(result, @"data-r2/graph/graph-10.ttl", false);

	
		}

		[TestMethod]
		public void Graph10b() {
	
					ImportData(@"data-r2/graph/data-g3.ttl");
		
					ImportGraph("data-r2/graph/data-g3-dup.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g3-dup.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-10.rq");
			CheckResult(result, @"data-r2/graph/graph-10.ttl", false);

	
		}

		[TestMethod]
		public void Graph11() {
	
					ImportData(@"data-r2/graph/data-g1.ttl");
		
					ImportGraph("data-r2/graph/data-g1.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g1.ttl"));
					ImportGraph("data-r2/graph/data-g2.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g2.ttl"));
					ImportGraph("data-r2/graph/data-g3.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g3.ttl"));
					ImportGraph("data-r2/graph/data-g4.ttl", new Uri(@"file:///D:/Projects/brightstar/working/sparql-test-suite/data-r2/graph/data-g4.ttl"));
		
			var result = ExecuteQuery(@"data-r2/graph/graph-11.rq");
			CheckResult(result, @"data-r2/graph/graph-11.ttl", false);

	
		}

		[TestMethod]
		public void TpDoubleDouble() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-double-double.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpDoubleFloat() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-double-float.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpDoubleDecimal() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-double-decimal.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpFloatFloat() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-float-float.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpFloatDecimal() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-float-decimal.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpDecimalDecimal() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-decimal-decimal.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpIntegerShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-integer-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpNonpositiveintegerShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-nonPositiveInteger-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpNegativeintegerShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-negativeInteger-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpLongShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-long-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpIntShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-int-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpShortShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpByteShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-byte-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpNonnegativeintegerShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-nonNegativeInteger-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpUnsignedlongShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-unsignedLong-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpUnsignedintShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-unsignedInt-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpUnsignedshortShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-unsignedShort-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpUnsignedbyteShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-unsignedByte-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpPositiveintegerShort() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-positiveInteger-short.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpShortDouble() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-double.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpShortFloat() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-float.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpShortDecimal() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-decimal.rq");
			CheckResult(result, @"data-r2/type-promotion/true.ttl", false);

	
		}

		[TestMethod]
		public void TpShortShortFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-short-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpByteShortFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-byte-short-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpShortLongFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-long-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpShortIntFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-int-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpShortByteFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-short-byte-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpDoubleFloatFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-double-float-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpDoubleDecimalFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-double-decimal-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void TpFloatDecimalFail() {
	
					ImportData(@"data-r2/type-promotion/tP.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/type-promotion/tP-float-decimal-fail.rq");
			CheckResult(result, @"data-r2/type-promotion/false.ttl", false);

	
		}

		[TestMethod]
		public void CastToXsdString() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-str.rq");
			CheckResult(result, @"data-r2/cast/cast-str.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdFloat() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-flt.rq");
			CheckResult(result, @"data-r2/cast/cast-flt.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdDouble() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-dbl.rq");
			CheckResult(result, @"data-r2/cast/cast-dbl.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdDecimal() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-dec.rq");
			CheckResult(result, @"data-r2/cast/cast-dec.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdInteger() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-int.rq");
			CheckResult(result, @"data-r2/cast/cast-int.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdDatetime() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-dT.rq");
			CheckResult(result, @"data-r2/cast/cast-dT.srx", false);

	
		}

		[TestMethod]
		public void CastToXsdBoolean() {
	
					ImportData(@"data-r2/cast/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/cast/cast-bool.rq");
			CheckResult(result, @"data-r2/cast/cast-bool.srx", false);

	
		}

		[TestMethod]
		public void TestLiteralTrue() {
	
					ImportData(@"data-r2/boolean-effective-value/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-boolean-literal.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-boolean-literal.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueTrue() {
	
					ImportData(@"data-r2/boolean-effective-value/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-1.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-1.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueFalse() {
	
					ImportData(@"data-r2/boolean-effective-value/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-2.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-2.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueAndOperator() {
	
					ImportData(@"data-r2/boolean-effective-value/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-3.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-3.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueOrOperator() {
	
					ImportData(@"data-r2/boolean-effective-value/data-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-4.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-4.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueOptional() {
	
					ImportData(@"data-r2/boolean-effective-value/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-5.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-5.ttl", false);

	
		}

		[TestMethod]
		public void TestBooleanEffectiveValueUnknownTypes() {
	
					ImportData(@"data-r2/boolean-effective-value/data-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/boolean-effective-value/query-bev-6.rq");
			CheckResult(result, @"data-r2/boolean-effective-value/result-bev-6.ttl", false);

	
		}

		[TestMethod]
		public void DawgBoundQuery001() {
	
					ImportData(@"data-r2/bound/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/bound/bound1.rq");
			CheckResult(result, @"data-r2/bound/bound1-result.ttl", false);

	
		}

		[TestMethod]
		public void Isliteral() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-isliteral-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-isliteral-1.ttl", false);

	
		}

		[TestMethod]
		public void Str1() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-str-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-str-1.ttl", false);

	
		}

		[TestMethod]
		public void Str2() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-str-2.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-str-2.ttl", false);

	
		}

		[TestMethod]
		public void Str3() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-str-3.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-str-3.ttl", false);

	
		}

		[TestMethod]
		public void Str4() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-str-4.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-str-4.ttl", false);

	
		}

		[TestMethod]
		public void Isblank1() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-blank-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-blank-1.ttl", false);

	
		}

		[TestMethod]
		public void Datatype1() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-datatype-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-datatype-1.ttl", false);

	
		}

		[TestMethod]
		public void Datatype2LiteralsWithADatatype() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-datatype-2.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-datatype-2.srx", false);

	
		}

		[TestMethod]
		public void Datatype3LiteralsWithADatatypeOfXsdString() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-datatype-3.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-datatype-3.srx", false);

	
		}

		[TestMethod]
		public void Lang1LiteralsWithALangTagOfSomeKind() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-lang-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-lang-1.srx", false);

	
		}

		[TestMethod]
		public void Lang2LiteralsWithALangTagOf() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-lang-2.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-lang-2.srx", false);

	
		}

		[TestMethod]
		public void Lang3GraphMatchingWithLangTagBeingADifferentCase() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-2.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-lang-3.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-lang-3.srx", false);

	
		}

		[TestMethod]
		public void Isuri1() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-uri-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-uri-1.ttl", false);

	
		}

		[TestMethod]
		public void Isiri1() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-iri-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-iri-1.ttl", false);

	
		}

		[TestMethod]
		public void Langmatches1() {
	
					ImportData(@"data-r2/expr-builtin/data-langMatches.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-langMatches-1.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-langMatches-1.ttl", false);

	
		}

		[TestMethod]
		public void Langmatches2() {
	
					ImportData(@"data-r2/expr-builtin/data-langMatches.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-langMatches-2.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-langMatches-2.ttl", false);

	
		}

		[TestMethod]
		public void Langmatches3() {
	
					ImportData(@"data-r2/expr-builtin/data-langMatches.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-langMatches-3.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-langMatches-3.ttl", false);

	
		}

		[TestMethod]
		public void Langmatches4() {
	
					ImportData(@"data-r2/expr-builtin/data-langMatches.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-langMatches-4.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-langMatches-4.ttl", false);

	
		}

		[TestMethod]
		public void LangmatchesBasic() {
	
					ImportData(@"data-r2/expr-builtin/data-langMatches-de.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/q-langMatches-de-de.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-langMatches-de.ttl", false);

	
		}

		[TestMethod]
		public void LangCaseInsensitiveEq() {
	
					ImportData(@"data-r2/expr-builtin/lang-case-sensitivity.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/lang-case-sensitivity-eq.rq");
			CheckResult(result, @"data-r2/expr-builtin/lang-case-insensitive-eq.srx", false);

	
		}

		[TestMethod]
		public void LangCaseInsensitiveNe() {
	
					ImportData(@"data-r2/expr-builtin/lang-case-sensitivity.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/lang-case-sensitivity-ne.rq");
			CheckResult(result, @"data-r2/expr-builtin/lang-case-insensitive-ne.srx", false);

	
		}

		[TestMethod]
		public void SametermSimple() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/sameTerm.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-sameTerm.ttl", false);

	
		}

		[TestMethod]
		public void SametermEq() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/sameTerm-eq.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-sameTerm-eq.ttl", false);

	
		}

		[TestMethod]
		public void SametermNotEq() {
	
					ImportData(@"data-r2/expr-builtin/data-builtin-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-builtin/sameTerm-not-eq.rq");
			CheckResult(result, @"data-r2/expr-builtin/result-sameTerm-not-eq.ttl", false);

	
		}

		[TestMethod]
		public void UnaryPlusn() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-unplus-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-unplus-1.srx", false);

	
		}

		[TestMethod]
		public void UnaryMinus() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-unminus-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-unminus-1.srx", false);

	
		}

		[TestMethod]
		public void Addition() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-plus-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-plus-1.srx", false);

	
		}

		[TestMethod]
		public void Subtraction() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-minus-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-minus-1.srx", false);

	
		}

		[TestMethod]
		public void Multiplication() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-mul-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-mul-1.srx", false);

	
		}

		[TestMethod]
		public void GreaterThanOrEquals() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-ge-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-ge-1.srx", false);

	
		}

		[TestMethod]
		public void LessThanOrEquals() {
	
					ImportData(@"data-r2/expr-ops/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-ops/query-le-1.rq");
			CheckResult(result, @"data-r2/expr-ops/result-le-1.srx", false);

	
		}

		[TestMethod]
		public void Equality11() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-1.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-1.ttl", false);

	
		}

		[TestMethod]
		public void Equality12() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-2.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-2.ttl", false);

	
		}

		[TestMethod]
		public void Equality13() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-3.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-3.ttl", false);

	
		}

		[TestMethod]
		public void Equality14() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-4.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-4.ttl", false);

	
		}

		[TestMethod]
		public void Equality15() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-5.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-5.ttl", false);

	
		}

		[TestMethod]
		public void Equality2VarTestEquals() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq2-1.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq2-1.ttl", false);

	
		}

		[TestMethod]
		public void Equality2VarTestNotEquals() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq2-1.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq2-1.ttl", false);

	
		}

		[TestMethod]
		public void Equality11Graph() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-graph-1.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-graph-1.ttl", false);

	
		}

		[TestMethod]
		public void Equality12Graph() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-graph-2.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-graph-2.ttl", false);

	
		}

		[TestMethod]
		public void Equality13Graph() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-graph-3.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-graph-3.ttl", false);

	
		}

		[TestMethod]
		public void Equality14Graph() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-graph-4.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-graph-4.ttl", false);

	
		}

		[TestMethod]
		public void Equality15Graph() {
	
					ImportData(@"data-r2/expr-equals/data-eq.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/expr-equals/query-eq-graph-5.rq");
			CheckResult(result, @"data-r2/expr-equals/result-eq-graph-5.ttl", false);

	
		}

		[TestMethod]
		public void RegexQuery001() {
	
					ImportData(@"data-r2/regex/regex-data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/regex/regex-query-001.rq");
			CheckResult(result, @"data-r2/regex/regex-result-001.ttl", false);

	
		}

		[TestMethod]
		public void RegexQuery002() {
	
					ImportData(@"data-r2/regex/regex-data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/regex/regex-query-002.rq");
			CheckResult(result, @"data-r2/regex/regex-result-002.ttl", false);

	
		}

		[TestMethod]
		public void RegexQuery003() {
	
					ImportData(@"data-r2/regex/regex-data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/regex/regex-query-003.rq");
			CheckResult(result, @"data-r2/regex/regex-result-003.ttl", false);

	
		}

		[TestMethod]
		public void RegexQuery004() {
	
					ImportData(@"data-r2/regex/regex-data-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/regex/regex-query-004.rq");
			CheckResult(result, @"data-r2/regex/regex-result-004.ttl", false);

	
		}

		[TestMethod]
		public void Kanji01() {
	
					ImportData(@"data-r2/i18n/kanji.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/i18n/kanji-01.rq");
			CheckResult(result, @"data-r2/i18n/kanji-01-results.ttl", false);

	
		}

		[TestMethod]
		public void Kanji02() {
	
					ImportData(@"data-r2/i18n/kanji.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/i18n/kanji-02.rq");
			CheckResult(result, @"data-r2/i18n/kanji-02-results.ttl", false);

	
		}

        [Description("Fails due to URI normalization in dotNetRdf"), TestMethod]
		public void Normalization01() {
	
					ImportData(@"data-r2/i18n/normalization-01.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/i18n/normalization-01.rq");
			CheckResult(result, @"data-r2/i18n/normalization-01-results.ttl", false);

	
		}

        [Description("Fails due to URI normalization in dotNetRdf"), TestMethod]
		public void Normalization02() {
	
					ImportData(@"data-r2/i18n/normalization-02.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/i18n/normalization-02.rq");
			CheckResult(result, @"data-r2/i18n/normalization-02-results.ttl", false);

	
		}

        [Description("Fails due to URI normalization in dotNetRdf"), TestMethod]
		public void Normalization03() {
	
					ImportData(@"data-r2/i18n/normalization-03.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/i18n/normalization-03.rq");
			CheckResult(result, @"data-r2/i18n/normalization-03-results.ttl", false);

	
		}

		[TestMethod]
		public void DawgConstructIdentity() {
	
					ImportData(@"data-r2/construct/data-ident.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/construct/query-ident.rq");
			CheckResult(result, @"data-r2/construct/result-ident.ttl", false);

	
		}

		[TestMethod]
		public void DawgConstructSubgraph() {
	
					ImportData(@"data-r2/construct/data-ident.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/construct/query-subgraph.rq");
			CheckResult(result, @"data-r2/construct/result-subgraph.ttl", false);

	
		}

		[TestMethod]
		public void DawgConstructReification1() {
	
					ImportData(@"data-r2/construct/data-reif.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/construct/query-reif-1.rq");
			CheckResult(result, @"data-r2/construct/result-reif.ttl", false);

	
		}

		[TestMethod]
		public void DawgConstructReification2() {
	
					ImportData(@"data-r2/construct/data-reif.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/construct/query-reif-2.rq");
			CheckResult(result, @"data-r2/construct/result-reif.ttl", false);

	
		}

		[TestMethod]
		public void DawgConstructOptional() {
	
					ImportData(@"data-r2/construct/data-opt.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/construct/query-construct-optional.rq");
			CheckResult(result, @"data-r2/construct/result-construct-optional.ttl", false);

	
		}

		[TestMethod]
		public void Ask1SparqlXmlResults() {
	
					ImportData(@"data-r2/ask/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/ask/ask-1.rq");
			CheckResult(result, @"data-r2/ask/ask-1.srx", false);

	
		}

		[TestMethod]
		public void Ask4SparqlXmlResults() {
	
					ImportData(@"data-r2/ask/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/ask/ask-4.rq");
			CheckResult(result, @"data-r2/ask/ask-4.srx", false);

	
		}

		[TestMethod]
		public void Ask7SparqlXmlResults() {
	
					ImportData(@"data-r2/ask/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/ask/ask-7.rq");
			CheckResult(result, @"data-r2/ask/ask-7.srx", false);

	
		}

		[TestMethod]
		public void Ask8SparqlXmlResults() {
	
					ImportData(@"data-r2/ask/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/ask/ask-8.rq");
			CheckResult(result, @"data-r2/ask/ask-8.srx", false);

	
		}

		[TestMethod]
		public void SelectDistinct_Asterix_() {
	
					ImportData(@"data-r2/distinct/data-star.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-star-1.rq");
			CheckResult(result, @"data-r2/distinct/distinct-star-1.srx", false);

	
		}

		[TestMethod]
		public void NumbersNoDistinct() {
	
					ImportData(@"data-r2/distinct/data-num.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/no-distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/no-distinct-num.srx", false);

	
		}

		[TestMethod]
		public void NumbersDistinct() {
	
					ImportData(@"data-r2/distinct/data-num.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/distinct-num.srx", false);

	
		}

		[TestMethod]
		public void StringsNoDistinct() {
	
					ImportData(@"data-r2/distinct/data-str.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/no-distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/no-distinct-str.srx", false);

	
		}

		[TestMethod]
		public void StringsDistinct() {
	
					ImportData(@"data-r2/distinct/data-str.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/distinct-str.srx", false);

	
		}

		[TestMethod]
		public void NodesNoDistinct() {
	
					ImportData(@"data-r2/distinct/data-node.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/no-distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/no-distinct-node.srx", false);

	
		}

		[TestMethod]
		public void NodesDistinct() {
	
					ImportData(@"data-r2/distinct/data-node.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/distinct-node.srx", false);

	
		}

		[TestMethod]
		public void OptNoDistinct() {
	
					ImportData(@"data-r2/distinct/data-opt.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/no-distinct-2.rq");
			CheckResult(result, @"data-r2/distinct/no-distinct-opt.srx", false);

	
		}

		[TestMethod]
		public void OptDistinct() {
	
					ImportData(@"data-r2/distinct/data-opt.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-2.rq");
			CheckResult(result, @"data-r2/distinct/distinct-opt.srx", false);

	
		}

		[TestMethod]
		public void AllNoDistinct() {
	
					ImportData(@"data-r2/distinct/data-all.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/no-distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/no-distinct-all.srx", false);

	
		}

		[TestMethod]
		public void AllDistinct() {
	
					ImportData(@"data-r2/distinct/data-all.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/distinct/distinct-1.rq");
			CheckResult(result, @"data-r2/distinct/distinct-all.srx", false);

	
		}

		[TestMethod]
		public void Sort1() {
	
					ImportData(@"data-r2/sort/data-sort-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-1.rq");
			CheckResult(result, @"data-r2/sort/result-sort-1.rdf", false);

	
		}

		[TestMethod]
		public void Sort2() {
	
					ImportData(@"data-r2/sort/data-sort-1.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-2.rq");
			CheckResult(result, @"data-r2/sort/result-sort-2.rdf", false);

	
		}

		[TestMethod]
		public void Sort3() {
	
					ImportData(@"data-r2/sort/data-sort-3.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-3.rq");
			CheckResult(result, @"data-r2/sort/result-sort-3.rdf", false);

	
		}

		[TestMethod]
		public void Sort4() {
	
					ImportData(@"data-r2/sort/data-sort-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-4.rq");
			CheckResult(result, @"data-r2/sort/result-sort-4.rdf", false);

	
		}

		[TestMethod]
		public void Sort5() {
	
					ImportData(@"data-r2/sort/data-sort-4.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-5.rq");
			CheckResult(result, @"data-r2/sort/result-sort-5.rdf", false);

	
		}

		[TestMethod]
		public void Sort6() {
	
					ImportData(@"data-r2/sort/data-sort-6.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-6.rq");
			CheckResult(result, @"data-r2/sort/result-sort-6.rdf", false);

	
		}

		[TestMethod]
		public void Sort7() {
	
					ImportData(@"data-r2/sort/data-sort-7.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-4.rq");
			CheckResult(result, @"data-r2/sort/result-sort-7.rdf", false);

	
		}

		[TestMethod]
		public void Sort8() {
	
					ImportData(@"data-r2/sort/data-sort-8.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-4.rq");
			CheckResult(result, @"data-r2/sort/result-sort-8.rdf", false);

	
		}

		[TestMethod]
		public void Sort9() {
	
					ImportData(@"data-r2/sort/data-sort-9.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-9.rq");
			CheckResult(result, @"data-r2/sort/result-sort-9.rdf", false);

	
		}

		[TestMethod]
		public void Sort10() {
	
					ImportData(@"data-r2/sort/data-sort-9.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-10.rq");
			CheckResult(result, @"data-r2/sort/result-sort-10.rdf", false);

	
		}

		[TestMethod]
		public void ExpressionSort() {
	
					ImportData(@"data-r2/sort/data-sort-numbers.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-numbers.rq");
			CheckResult(result, @"data-r2/sort/result-sort-numbers.ttl", false);

	
		}

		[TestMethod]
		public void BuiltinSort() {
	
					ImportData(@"data-r2/sort/data-sort-builtin.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-builtin.rq");
			CheckResult(result, @"data-r2/sort/result-sort-builtin.ttl", false);

	
		}

		[TestMethod]
		public void FunctionSort() {
	
					ImportData(@"data-r2/sort/data-sort-function.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/sort/query-sort-function.rq");
			CheckResult(result, @"data-r2/sort/result-sort-function.ttl", false);

	
		}

		[TestMethod]
		public void Limit1() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-01.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-01.ttl", false);

	
		}

		[TestMethod]
		public void Limit2() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-02.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-02.ttl", false);

	
		}

		[TestMethod]
		public void Limit3() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-03.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-03.ttl", false);

	
		}

		[TestMethod]
		public void Limit4() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-04.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-04.ttl", false);

	
		}

		[TestMethod]
		public void Offset1() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-10.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-10.ttl", false);

	
		}

		[TestMethod]
		public void Offset2() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-11.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-11.ttl", false);

	
		}

		[TestMethod]
		public void Offset3() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-12.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-12.ttl", false);

	
		}

		[TestMethod]
		public void Offset4() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-13.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-13.ttl", false);

	
		}

		[TestMethod]
		public void Slice1() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-20.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-20.ttl", false);

	
		}

		[TestMethod]
		public void Slice2() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-21.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-21.ttl", false);

	
		}

		[TestMethod]
		public void Slice3() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-22.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-22.ttl", false);

	
		}

		[TestMethod]
		public void Slice4() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-23.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-23.ttl", false);

	
		}

		[TestMethod]
		public void Slice5() {
	
					ImportData(@"data-r2/solution-seq/data.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/solution-seq/slice-24.rq");
			CheckResult(result, @"data-r2/solution-seq/slice-results-24.ttl", false);

	
		}

		[TestMethod]
		public void SelectReduced_Asterix_() {
	
					ImportData(@"data-r2/reduced/reduced-star.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/reduced/reduced-1.rq");
			CheckResult(result, @"data-r2/reduced/reduced-1.srx", false);

	
		}

		[TestMethod]
		public void SelectReduced_QuestionMark_xWithStrings() {
	
					ImportData(@"data-r2/reduced/reduced-str.ttl");
		
		
			var result = ExecuteQuery(@"data-r2/reduced/reduced-2.rq");
			CheckResult(result, @"data-r2/reduced/reduced-2.srx", false);

	
		}

		#endregion

		#region Support Methods

        private Dictionary<string, string> _bnodeMappings;

		private void ImportData(string dataPath, string defaultGraphUri = null)
        {
            var g = new Graph();
		    var importId = Guid.NewGuid();
            FileLoader.Load(g, dataPath);

            _bnodeMappings = new Dictionary<string, string>();

            foreach (var t in g.Triples)
            {
                if (t.Object.NodeType == NodeType.Literal)
                {
                    var litNode = t.Object as LiteralNode;
                    _store.InsertTriple(
                        GetNodeString(t.Subject, importId),
                        GetNodeString(t.Predicate, importId),
                        litNode.Value,
                        true,
                        litNode.DataType == null ? null : litNode.DataType.ToString(),
                        litNode.Language,
                        defaultGraphUri ?? Constants.DefaultGraphUri
                        );
                }
                else
                {
                    _store.InsertTriple(
                        GetNodeString(t.Subject, importId),
                        GetNodeString(t.Predicate, importId),
                        GetNodeString(t.Object, importId),
                        false,
                        null,
                        null,
                        defaultGraphUri ?? Constants.DefaultGraphUri
                        );
                }
            }
            _store.Commit(Guid.Empty);
        }

        private string GetNodeString(INode node, Guid importId)
        {
            if (node.NodeType == NodeType.Uri)
            {
                return (node as UriNode).Uri.ToString();
            }
            if (node.NodeType == NodeType.Blank)
            {
                var bnode = node as BlankNode;
                if (_bnodeMappings.ContainsKey(bnode.InternalID))
                {
                    return _bnodeMappings[bnode.InternalID];
                } else
                {
                    var skolemizedUri = Constants.GeneratedUriPrefix + Guid.NewGuid();
                    _bnodeMappings[bnode.InternalID] = skolemizedUri;
                    return skolemizedUri;
                }

                //return "_:bnode-" + importId + "-" + (node as BlankNode).InternalID;                
            }
            Assert.Fail("Unexpected node type in GetNodeString: {0}", node.NodeType);
            return null;
        }


		private void ImportGraph(string dataPath, Uri graphUri) {
            ImportData(dataPath, graphUri.ToString());
		}

		private string ExecuteQuery(string queryPath)
		{
		    var queryExp = File.ReadAllText(queryPath);
            return _store.ExecuteSparqlQuery(queryExp, SparqlResultsFormat.Xml);
		}

		private void CheckResult(string results, string expectedResultPath, bool laxCardinality) 
        {
            Assert.IsNotNull(results);
		    var resultExtension = Path.GetExtension(expectedResultPath).ToLower();
            if (resultExtension.Equals(".srx"))
            {
                CompareSparqlResults(results, expectedResultPath, laxCardinality);
            } 
            else if (resultExtension.Equals(".ttl") || resultExtension.Equals(".rdf"))
            {
                CompareResultGraphs(results, expectedResultPath, laxCardinality);
            }
            else {
				Assert.Fail("Don't know how to compare results to results file {0}", expectedResultPath);              
			}
		}

        private void CompareSparqlResults(string results, string expectedResultsPath, bool reduced)
        {
            var p = new SparqlXmlParser();
            var actualResultSet = new SparqlResultSet();
            using (var tr = new StringReader(results))
            {
                p.Load(actualResultSet, tr);
            }
            var expectedResultSet = new SparqlResultSet();
            p.Load(expectedResultSet, expectedResultsPath);
            var bnodeMap = new Dictionary<string, string>();
            CompareSparqlResults(actualResultSet, expectedResultSet, reduced, bnodeMap);
        }

        private void CompareResultGraphs(string results, string expectedResultsPath, bool reduced)
        {
            var expectedResultGraph = new Graph();
            FileLoader.Load(expectedResultGraph, expectedResultsPath);
            var resultSet = expectedResultGraph.GetUriNode(new Uri("http://www.w3.org/2001/sw/DataAccess/tests/result-set#ResultSet"));
            if (resultSet != null)
            {
                var rdfParser = new SparqlRdfParser();
                var xmlParser = new SparqlXmlParser();
                var actualResultSet = new SparqlResultSet();
                var expectedResultSet = new SparqlResultSet();
                using (var tr = new StringReader(results))
                {
                    xmlParser.Load(actualResultSet, tr);
                }
                rdfParser.Load(expectedResultSet, expectedResultsPath);
                var bnodeMap = new Dictionary<string, string>();
                CompareSparqlResults(actualResultSet, expectedResultSet, reduced, bnodeMap);
            }
            else
            {
                // This is a constructed graph
                var actualGraph = new Graph();
                actualGraph.LoadFromString(results);
                CompareTripleCollections(actualGraph.Triples, expectedResultGraph.Triples, reduced);
            }
        }

        private void CompareSparqlResults(SparqlResultSet actual, SparqlResultSet expected, bool reduced, Dictionary<string,string> bnodeMap)
        {
            if (expected.ResultsType == SparqlResultsType.Boolean)
            {
                Assert.IsTrue(actual.ResultsType == SparqlResultsType.Boolean);
                Assert.AreEqual(expected.Result, actual.Result);
            }
            else if (expected.ResultsType == SparqlResultsType.VariableBindings)
            {
                if (reduced)
                {
                    Assert.IsTrue(actual.Results.Count <= expected.Results.Count,
                                  "Too many results returned expected <= {0}, got {1}",
                                  expected.Results.Count, actual.Results.Count);
                }
                else
                {
                    Assert.AreEqual(expected.Results.Count, actual.Results.Count,
                                    "Unexpected number of rows in results.");
                }
                foreach (var actualSolution in actual.Results)
                {
                    Assert.IsTrue(expected.Results.Any(x => CompareSolutions(actualSolution, x, bnodeMap)),
                                  "Could not find a match for solution {0} in the expected results set", actualSolution);
                }
            }
            else
            {
                Assert.Fail("Cannot compare results to result set of type {0}", expected.ResultsType);
            }
        }

        private static bool CompareSolutions(SparqlResult x, SparqlResult y, Dictionary<string,string> bnodeMap)
        {
            var boundVarsX = x.Variables.Where(v=>x.HasValue(v) && x.Value(v)!=null);
            var boundVarsY = y.Variables.Where(v=>y.HasValue(v) && y.Value(v)!=null);
            if (!boundVarsX.Any() && !boundVarsY.Any()) return true;
            if (x.Variables.Count().Equals(y.Variables.Count()) &&
                x.Variables.All(xv=>y.Variables.Contains(xv)))
            {
                foreach (var xv in x.Variables)
                {
                    var xb = x[xv];
                    var yb = y[xv];
                    if (!CompareNodes(xb, yb, bnodeMap)) return false;
                }
                return true;
            }
            return false;
        }

        private static bool CompareNodes(INode actualNode, INode expectedNode, Dictionary<string,string> bnodeMap)
        {
            // If either one is null, they must both be null
            if (actualNode == null || expectedNode == null) return actualNode == null && expectedNode == null;

            // if (!actualNode.NodeType.Equals(expectedNode.NodeType)) return false;
            switch(expectedNode.NodeType)
            {
                case NodeType.Blank:
                    var uriNode = actualNode as IUriNode;
                    if (uriNode == null) return false;
                    var bnode = expectedNode as IBlankNode;
                    if (bnodeMap.ContainsKey(bnode.InternalID))
                    {
                        return uriNode.Uri.ToString().Equals(bnodeMap[bnode.InternalID]);
                    } else if (uriNode.Uri.ToString().StartsWith(Constants.GeneratedUriPrefix))
                    {                        
                        bnodeMap[bnode.InternalID] = uriNode.Uri.ToString();
                        return true;
                    }
                    return false;
                case NodeType.Literal:
                    if (!actualNode.NodeType.Equals(expectedNode.NodeType)) return false;
                    var xl = actualNode as LiteralNode;
                    var yl = expectedNode as LiteralNode;
                    if (!xl.Value.Equals(yl.Value)) return false;
                    var xd = xl.DataType == null ? RdfDatatypes.PlainLiteral : xl.DataType.ToString();
                    var yd = yl.DataType == null ? RdfDatatypes.PlainLiteral : yl.DataType.ToString();
                    if (!xd.Equals(yd)) return false;
                    var xlang = xl.Language ?? String.Empty;
                    var ylang = yl.Language ?? String.Empty;
                    if (!xlang.Equals(ylang, StringComparison.InvariantCultureIgnoreCase)) return false;
                    break;
                case NodeType.Uri:
                    if (!actualNode.NodeType.Equals(expectedNode.NodeType)) return false;
                    var xu = actualNode as UriNode;
                    var yu = expectedNode as UriNode;
                    if (!xu.Uri.Equals(yu.Uri)) return false;
                    break;
            }
            return true;
        }

        private static void CompareTripleCollections(BaseTripleCollection actualTriples, BaseTripleCollection expectedTriples, bool reduced) 
		{
            var actualTripleList = new List<Triple>(actualTriples);
            var expectedTripleList = new List<Triple>(expectedTriples);
            var alreadySeen = new HashSet<Triple>();
            var bnodeMap = new Dictionary<string, string>();

            while(actualTripleList.Count > 0)
            {
                var at = actualTripleList[0];
                actualTripleList.Remove(at);
                if (alreadySeen.Contains(at)) continue;
                var match = expectedTripleList.Find(x => TripleMatch(x, at, bnodeMap));
                if (match == null)
                {
                    Assert.Fail("No match found for actual triple {0} in expected triples set", at);
                }

                expectedTripleList.Remove(match);
                alreadySeen.Add(at);
            }
            Assert.IsTrue(actualTripleList.Count == 0);
            Assert.IsTrue(expectedTripleList.Count == 0, "Left with some unmatched triples in the expected triples set: {0}",
                String.Join(",", expectedTripleList.Select(t=>t.ToString())));
		}

        private static bool TripleMatch(Triple expectedTriple, Triple actualTriple, Dictionary<string, string> bnodeMap)
        {
            var subjMatch = NodeMatch(expectedTriple.Subject, actualTriple.Subject, bnodeMap);
            var predMatch = NodeMatch(expectedTriple.Predicate, actualTriple.Predicate, bnodeMap);
            var objMatch = NodeMatch(expectedTriple.Object, actualTriple.Object, bnodeMap);

            if (subjMatch && predMatch && objMatch)
            {
                if (actualTriple.Subject is IUriNode &&
                    expectedTriple.Subject is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Subject as IUriNode).Uri.ToString()))
                {
                    bnodeMap[(actualTriple.Subject as IUriNode).Uri.ToString()] = (expectedTriple.Subject as IBlankNode).InternalID;
                }
                if (actualTriple.Predicate is IUriNode &&
                    expectedTriple.Predicate is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Predicate as IUriNode).Uri.ToString()))
                {
                    bnodeMap[(actualTriple.Predicate as IUriNode).Uri.ToString()] = (expectedTriple.Predicate as IBlankNode).InternalID;

                    //bnodeMap[(actualTriple.Predicate as IBlankNode).InternalID] = (expectedTriple.Predicate as IBlankNode).InternalID;
                }
                if (actualTriple.Object is IUriNode &&
                    expectedTriple.Object is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Object as IUriNode).Uri.ToString()))
                {
                    bnodeMap[(actualTriple.Object as IUriNode).Uri.ToString()] = (expectedTriple.Object as IBlankNode).InternalID;

                    //bnodeMap[(actualTriple.Object as IBlankNode).InternalID] = (expectedTriple.Object as IBlankNode).InternalID;
                }

                // both blanks

                if (actualTriple.Subject is IBlankNode &&
                    expectedTriple.Subject is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Subject as IBlankNode).InternalID))
                {
                    bnodeMap[(actualTriple.Subject as IBlankNode).InternalID] = (expectedTriple.Subject as IBlankNode).InternalID;
                }
                if (actualTriple.Predicate is IBlankNode &&
                    expectedTriple.Predicate is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Predicate as IBlankNode).InternalID))
                {
                    bnodeMap[(actualTriple.Predicate as IBlankNode).InternalID] = (expectedTriple.Predicate as IBlankNode).InternalID;

                    //bnodeMap[(actualTriple.Predicate as IBlankNode).InternalID] = (expectedTriple.Predicate as IBlankNode).InternalID;
                }
                if (actualTriple.Object is IBlankNode &&
                    expectedTriple.Object is IBlankNode &&
                    !bnodeMap.ContainsKey((actualTriple.Object as IBlankNode).InternalID))
                {
                    bnodeMap[(actualTriple.Object as IBlankNode).InternalID] = (expectedTriple.Object as IBlankNode).InternalID;

                    //bnodeMap[(actualTriple.Object as IBlankNode).InternalID] = (expectedTriple.Object as IBlankNode).InternalID;
                }
            }
            return subjMatch && objMatch && predMatch;
            /*
            return NodeMatch(expectedTriple.Subject, actualTriple.Subject, bnodeMap) &&
                   NodeMatch(expectedTriple.Predicate, actualTriple.Predicate, bnodeMap) &&
                   NodeMatch(expectedTriple.Object, actualTriple.Object, bnodeMap);
             */
        }

        private static bool NodeMatch(INode expectedNode, INode actualNode, Dictionary<string, string>bnodeMap)
        {
            if (expectedNode is IBlankNode && actualNode is IUriNode)
            {
                var actualUriNode = actualNode as IUriNode;
                var expectedBNode = expectedNode as IBlankNode;
                if (bnodeMap.ContainsKey(actualUriNode.Uri.ToString()))
                {
                    return expectedBNode.InternalID.Equals(bnodeMap[actualUriNode.Uri.ToString()]);
                }
                return true;
            }
            if (expectedNode is IBlankNode && actualNode is IBlankNode)
            {
                var ebNode = expectedNode as IBlankNode;
                var abNode = actualNode as IBlankNode;
                if (bnodeMap.ContainsKey(abNode.InternalID))
                {
                    return ebNode.InternalID.Equals(bnodeMap[abNode.InternalID]);
                }
                return true; // ebNode.InternalID.Equals(abNode.InternalID);
            }
            if (!expectedNode.NodeType.Equals(actualNode.NodeType)) return false;
            return expectedNode.Equals(actualNode);
        }

        //private static Triple MakeMatchTriple(Triple actualTriple, Dictionary<string, string> bnodeMap)
        //{
        //    return new Triple(
        //        MakeMatchNode(actualTriple.Subject, bnodeMap),
        //        MakeMatchNode(actualTriple.Predicate, bnodeMap),
        //        MakeMatchNode(actualTriple.Object, bnodeMap),
        //        actualTriple.GraphUri);
        //}

        //private static INode MakeMatchNode(INode n, Dictionary<string, string> bnodeMap)
        //{
        //    if (n is IBlankNode)
        //    {
        //        var b = n as IBlankNode;
        //        if (bnodeMap.ContainsKey(b.InternalID))
        //        {
        //            return n.Graph.CreateBlankNode(bnodeMap[b.InternalID]);
        //        }
        //    }
        //    return n;
        //}
		#endregion
	}
}